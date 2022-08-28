using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionBehaviour : MonoBehaviour {
    [SerializeField] private Player player;
    private void OnTriggerEnter(Collider collider) {
        Destroy(collider.gameObject);
        player.LosesLifespan();
        
    }

}
