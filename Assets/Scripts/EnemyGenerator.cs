using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour {
    
    [SerializeField] private GameObject enemy;
    [SerializeField] private float spawnTime = 2f;
    [SerializeField] private AudioSource spawnSound;
    private float timer;
    
    void Start() { timer = spawnTime; }
    
    void Update() {
        timer -= Time.deltaTime;
        if (timer <= 0) {
            Instantiate(enemy, transform.position, Quaternion.identity);
            spawnSound.Play();
            timer = spawnTime;
        }
    }
    
}

