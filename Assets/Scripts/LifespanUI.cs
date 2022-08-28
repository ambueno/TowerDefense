using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LifespanUI : MonoBehaviour {
    [SerializeField]
    private TextMeshProUGUI text;
    [SerializeField] public Player player;
    void Start () { text = GetComponent<TMPro.TextMeshProUGUI> (); }
    void Update() { text.text = ("Vida: " + player.GetLifespan()); }
}
