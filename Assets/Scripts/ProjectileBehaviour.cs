using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBehaviour : MonoBehaviour {
    private Transform target;
    [SerializeField] private float projectileSpeed = 20f;
    [SerializeField] private float projectileDamage = 10f;

    void Update() {
        if (target == null) {
            Destroy(gameObject);
            return;
        }
        Vector3 direction = target.position - transform.position;
        float distanceThisFrame = projectileSpeed * Time.deltaTime;
        if (direction.magnitude <= projectileSpeed * Time.deltaTime) {
            HitTarget();
            return;
        }
        //transform.Translate(direction.normalized * projectileSpeed * Time.deltaTime);
    }
    
    public void Seek(Transform target) { this.target = target; }
    
    void HitTarget() {
       // if (collidedObject.gameObject.tag == "EnemyTag") {
            target.GetComponent<EnemyBehaviour>().TakeDamage(projectileDamage);
            Destroy(gameObject);
        //}
    }
}
