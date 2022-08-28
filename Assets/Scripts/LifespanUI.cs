using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LifespanUI : MonoBehaviour {
    [SerializeField]
    private TextMeshProUGUI text;
    [SerializeField] private Player player;
    [SerializeField] private TowerBuilder towerBuilder;

    void Start () { text = GetComponent<TMPro.TextMeshProUGUI> (); }
    void Update() { text.text = ("Vida: " + player.GetLifespan() + "\n" + "Torres" + "\n" + "restantes:" + towerBuilder.GetTowerCount()); }
}
