using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
    [SerializeField] private GameObject gameOver;
    
    void Start() { gameOver.SetActive(false); }

    public void Restart() { SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); }
    
}
