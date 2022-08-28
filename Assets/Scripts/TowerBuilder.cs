using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerBuilder : MonoBehaviour {
    [SerializeField] private GameObject towerPrefab;
    
    [SerializeField] private int towerCount = 8;
    
    [SerializeField] private float radius = 1000000.0f;
    
    private Vector3 elementPosition;

    void Update() {
        if (towerCount > 0 ){
            if (Input.GetMouseButtonDown(0)) {
                Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out RaycastHit rayData, radius);

                if (rayData.collider) {
                    elementPosition = rayData.point;
                    elementPosition.y += 0;
                    Instantiate(towerPrefab, elementPosition, Quaternion.identity);
                }

                towerCount--;
            }
        }
    }
    
    public int GetTowerCount() { return towerCount; }
}
