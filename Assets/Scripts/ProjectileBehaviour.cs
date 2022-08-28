using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBehaviour : MonoBehaviour
{

    [SerializeField] private float projectileSpeed = 20f;
    [SerializeField] private float projectileDamage = 1f;
    private EnemyBehaviour enemy;
    
    void Update() {
        transform.Translate(Vector3.forward * projectileSpeed * Time.deltaTime);
    }
    
    void OnTriggerEnter(Collider collidedObject) {
        if (collidedObject.gameObject.tag == "Enemy") {
            enemy = collidedObject.gameObject.GetComponent<EnemyBehaviour>();
            enemy.TakeDamage(projectileDamage);
            Destroy(gameObject);
        }
    }
    
    public void SetTarget(EnemyBehaviour enemy) { this.enemy = enemy; }
}
