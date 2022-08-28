using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileData : MonoBehaviour {
    public static float damage = 10.0f;
    [SerializeField]
    private float lifespan = 5.0f;

    void Start() { Destroy(gameObject, lifespan); }

}
