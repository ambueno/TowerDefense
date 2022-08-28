using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundsManager : MonoBehaviour
{
    [SerializeField]
    private AudioSource deathSound;
    [SerializeField] private AudioSource spawnSound;
    [SerializeField] private AudioSource collisionSound;
    public void DeathSoundPlayer() { deathSound.Play(); }

    public void SpawnSoundPlayer() { spawnSound.Play(); }
    
    public void CollisionSoundPlayer() { collisionSound.Play(); }

}
