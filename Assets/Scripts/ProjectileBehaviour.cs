using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBehaviour : MonoBehaviour {
    private EnemyBehaviour target;
    
    private float projectileLifeTime = 10;
    [SerializeField] private float projectileSpeed;

    void Start() {
        Destroy(this.gameObject, projectileLifeTime);
    }

    void Update() {
        transform.position = transform.position + transform.forward * projectileSpeed * Time.deltaTime;
        transform.rotation = Quaternion.LookRotation(target.transform.position - transform.position);
    }

    public void SetTarget(EnemyBehaviour target) { this.target = target; }

    private void OnTriggerEnter(Collider collidedObject) {
        Debug.Log("Projectile collided with " + collidedObject.name);
        if (collidedObject.CompareTag("EnemyTag")) {
            Destroy(this.gameObject);
        }
    }
}
