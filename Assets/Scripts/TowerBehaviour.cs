using System.Collections;
using System.Collections.Generic;
using System.Security.Permissions;
using UnityEngine;

public class TowerBehaviour : MonoBehaviour {

    [SerializeField] private GameObject projectilePrefab;
    [SerializeField] private float reloadTime = 1f;
    [SerializeField] private float range = 20f;
    
    private float fireRate = 1f;
    private float fireCountdown = 0f;
    private Transform target;
    private EnemyBehaviour targetEnemy;
    private float timeSinceLastShot;

    public string enemyTag = "EnemyTag";

    public Transform partToRotate;
    public float turnSpeed = 10f;

    public Transform firePoint;
    
    void Start () { InvokeRepeating("FindClosestEnemy", 0f, 0.5f); }
    
    void Update() {
        if (target) {
            Vector3 direction = target.position - transform.position;
            Quaternion lookRotation = Quaternion.LookRotation(direction);
            Vector3 rotation = Quaternion.Lerp(partToRotate.rotation, lookRotation, Time.deltaTime * turnSpeed).eulerAngles;
            partToRotate.rotation = Quaternion.Euler(0f, rotation.y, 0f);
            if (fireCountdown <= 0f) {
                Shoot();
                fireCountdown = 1f / fireRate;
            }
            fireCountdown -= Time.deltaTime;
        }
    }
    
    private void FindClosestEnemy() {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag(enemyTag);
        GameObject closestEnemy = null;
        float closestDistance = float.MaxValue;
        foreach (GameObject enemy in enemies) {
            float distance = Vector3.Distance(transform.position, enemy.transform.position);
            if (distance < closestDistance) {
                closestEnemy = enemy;
                closestDistance = distance;
            }
        }
        if (closestEnemy != null && closestDistance <= range) {
            target = closestEnemy.transform;
            targetEnemy = closestEnemy.GetComponent<EnemyBehaviour>();
        } else { 
            target = null;
        }
    }
    
    private void Shoot() {
        timeSinceLastShot += Time.deltaTime;
        if (timeSinceLastShot >= reloadTime) {
            timeSinceLastShot = 0;
            GameObject projectile = Instantiate(projectilePrefab, transform.position, Quaternion.identity);
            projectile.GetComponent<ProjectileBehaviour>().Seek(target);
        }
    }

}
