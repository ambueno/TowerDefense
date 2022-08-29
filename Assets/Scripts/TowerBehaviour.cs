using System.Collections;
using System.Collections.Generic;
using System.Security.Permissions;
using UnityEngine;

public class TowerBehaviour : MonoBehaviour {
    [SerializeField] private GameObject projectilePrefab;
    [SerializeField] private float reloadTime = 2f;
    [SerializeField] private float range = 200f;
    private float lastShot;

    void Update(){
        EnemyBehaviour target = FindClosestEnemy();
        if (target) Shoot(target);
    }

    private void Shoot(EnemyBehaviour enemy){
        if (Time.time - lastShot > reloadTime){
            lastShot = Time.time;
            GameObject projectile = Instantiate(projectilePrefab, transform.position, Quaternion.identity);
            projectile.GetComponent<ProjectileBehaviour>().SetTarget(enemy);
        }
    }

    private EnemyBehaviour FindClosestEnemy(){
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("EnemyTag");
        foreach (GameObject enemy in enemies) {
            if (IsReachable(enemy)) return enemy.GetComponent<EnemyBehaviour>();
        }
        return null;
    }

    private bool IsReachable(GameObject enemy){
        float distance = Vector3.Distance(Vector3.ProjectOnPlane(this.transform.position, Vector3.up), Vector3.ProjectOnPlane(enemy.transform.position, Vector3.up));
        return distance <= range;
    }

}
