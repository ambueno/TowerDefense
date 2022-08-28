using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerBuilder : MonoBehaviour {
    [SerializeField] private GameObject towerPrefab;

    private Vector3 elementPosition;

    public int towersLeft = 7;

    public int AmountOfTowersLeft() { return towersLeft; }
    
    private bool OnClick() { return Input.GetMouseButtonDown(0); }
    
    void Update() {
        if (towersLeft > 0 ){
            if (OnClick()) {
                Vector3 clickPosition = Input.mousePosition;
                Ray cameraRay = Camera.main.ScreenPointToRay(clickPosition);

                float maxLenght = 1000000.0f;

                Physics.Raycast(cameraRay, out RaycastHit rayData, maxLenght);

                if (rayData.collider) {
                    elementPosition = rayData.point;
                    elementPosition.y += 0;
                    Instantiate(towerPrefab, elementPosition, Quaternion.identity);
                }

                towersLeft--;
            }
        }
    }
}
