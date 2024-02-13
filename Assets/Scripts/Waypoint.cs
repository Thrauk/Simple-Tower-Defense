using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour
{
    [SerializeField] Tower towerPreafab;

    [SerializeField] bool isPlaceable;
    public bool IsPlaceable {
        get {
            return isPlaceable;
        }
    }


    void OnMouseDown()
    {
        if (isPlaceable)
        {
            bool isPlaced = towerPreafab.CreateTower(towerPreafab, transform.position);
            isPlaceable = !isPlaced;
        }
    }
}
