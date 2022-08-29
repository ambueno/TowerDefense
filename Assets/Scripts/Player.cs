using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    [SerializeField] private GameObject gameOver;
    [SerializeField] private int lifespan = 5;

    void Update() {
        if(IsDead()) {
            gameOver.SetActive(true);
            ResetLifespan();
            Time.timeScale = 0;
        }
    }

    public bool IsDead() { return lifespan <= 0; }
    
    public int GetLifespan() { return lifespan; }
    
    public void LosesLifespan() { lifespan--; }
    
    public void ResetLifespan() { lifespan = 5; }

}
