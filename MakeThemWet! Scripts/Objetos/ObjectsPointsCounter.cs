using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsPointsCounter : MonoBehaviour
{
    public GameObject controller;

    void OnTriggerEnter2D(Collider2D col){
        if(col.gameObject.CompareTag("Stickman")){
            controller.gameObject.GetComponent<ControlGame>().AddPoints();
        }
    }
}