using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileCollisionBehaviour : MonoBehaviour {
    [SerializeField]
    private SoundsManager soundsManager;
    
    private void OnTriggerEnter(Collider collider) {
            soundsManager.CollisionSoundPlayer();
            Destroy(this.gameObject);
    }

}
