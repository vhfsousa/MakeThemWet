using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectLoseLife : MonoBehaviour
{
    [SerializeField] private AudioSource objectAudioS;
    [SerializeField] private AudioClip objectHit;
    public GameObject controller;
    
    public void OnCollisionEnter2D (Collision2D col){
        if(col.gameObject.CompareTag("Stickman")){
            objectAudioS.PlayOneShot(objectHit);
            controller.gameObject.GetComponent<ControlGame>().LoseLife();
        }
    }
}