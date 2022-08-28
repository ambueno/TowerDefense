using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameOver : MonoBehaviour {
    [SerializeField] private GameObject gameOverGameObject;
    [SerializeField] private Player player;
    void Start() { gameOverGameObject.SetActive(false); }

}
