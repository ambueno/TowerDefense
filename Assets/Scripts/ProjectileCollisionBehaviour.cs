using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileCollisionBehaviour : MonoBehaviour {
    private void OnTriggerEnter(Collider collider) { Destroy(this.gameObject); }
}
