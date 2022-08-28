using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour {
    private float enemyHealth = 100;
    
    void Update(){ if(enemyHealth <= 0) Destroy(gameObject); }
    
    void Start(){
        UnityEngine.AI.NavMeshAgent agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        agent.SetDestination(GameObject.Find("End").transform.position);
    }

    public void TakeDamage(float damage){ enemyHealth -= damage; }
}
