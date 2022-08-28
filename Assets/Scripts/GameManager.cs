using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject gameOver;
    
    private void Start() { gameOver.SetActive(false); }

    void Update() { if(GameOver()) gameOver.SetActive(true); }
    
    private bool GameOver() { return player.GetComponent<Player>().IsDead(); }
    
    public void Restart() {
        gameOver.SetActive(false);
        player.GetComponent<Player>().Restart();
    }
}
