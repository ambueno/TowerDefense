using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour {
    private float projectileDamage = 10f;

    private float enemyHealth = 80;
    
    void Update(){ if(enemyHealth <= 0) Destroy(gameObject); }
    
    void Start(){
        UnityEngine.AI.NavMeshAgent agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        agent.SetDestination(GameObject.Find("End").transform.position);
    }
    
    private void OnTriggerEnter(Collider collidedObject) {
        enemyHealth -= projectileDamage;
    }
}
