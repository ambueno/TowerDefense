using System.Collections;
using System.Collections.Generic;
using System.Security.Permissions;
using UnityEngine;

public class TowerBehaviour : MonoBehaviour {

    [SerializeField] private GameObject projectilePrefab;
    [SerializeField] private float reloadTime = 1f;
    [SerializeField] private float range = 200f;
    private float timeSinceLastShot;
    
    void Update() {
        EnemyBehaviour closestEnemy = FindClosestEnemy();
        if (closestEnemy) {
            Vector3 enemyPosition = closestEnemy.transform.position;
            Vector3 towerPosition = transform.position;
            Vector3 direction = enemyPosition - towerPosition;
            float distance = direction.magnitude;
            if (distance < range) {
                Shoot(closestEnemy);
            }
        }
    }
    
    private EnemyBehaviour FindClosestEnemy() {
        EnemyBehaviour[] enemies = FindObjectsOfType<EnemyBehaviour>();
        EnemyBehaviour closestEnemy = null;
        float closestDistance = float.MaxValue;
        foreach (EnemyBehaviour enemy in enemies) {
            Vector3 enemyPosition = enemy.transform.position;
            Vector3 towerPosition = transform.position;
            Vector3 direction = enemyPosition - towerPosition;
            float distance = direction.magnitude;
            if (distance < closestDistance) {
                closestEnemy = enemy;
                closestDistance = distance;
            }
        }
        return closestEnemy;
    }
    
    private void Shoot(EnemyBehaviour enemy) {
        timeSinceLastShot += Time.deltaTime;
        if (timeSinceLastShot >= reloadTime) {
            timeSinceLastShot = 0;
            GameObject projectile = Instantiate(projectilePrefab, transform.position, Quaternion.identity);
            projectile.GetComponent<ProjectileBehaviour>().SetTarget(enemy);
        }
    }

}
