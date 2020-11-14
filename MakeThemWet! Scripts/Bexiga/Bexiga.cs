using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bexiga : MonoBehaviour
{
    [SerializeField] private float translateSpeed;
    [SerializeField] private GameObject controller;
    [SerializeField] private Rigidbody2D ballonRB;
    [SerializeField] private Animator ballonAnim;
    [SerializeField] private AudioSource somBexiga;
    [SerializeField] private AudioClip bexigaBatendoNoStickman;
    [SerializeField] private AudioClip bexigaExplodindo;

    void Start()
    {
        
    }

    void Update()
    {
        if(ballonAnim.GetBool("Estourou") == false){
            this.gameObject.transform.Translate (new Vector3 ( translateSpeed * Time.deltaTime * -1, 0, 0));
        }
    }

    void OnTriggerExit2D(Collider2D col){
        if(col.gameObject.CompareTag("Espadada")){
            somBexiga.PlayOneShot(bexigaExplodindo);
            controller.gameObject.GetComponent<ControlGame>().AddPoints();
            ballonRB.bodyType = RigidbodyType2D.Dynamic;
            ballonRB.constraints = RigidbodyConstraints2D.FreezePositionX;
            ballonAnim.SetBool("Estourou", true);
        }
    }

    void OnCollisionEnter2D(Collision2D col){
        if(col.gameObject.CompareTag("Stickman")){
            somBexiga.PlayOneShot(bexigaBatendoNoStickman);
            controller.gameObject.GetComponent<ControlGame>().LoseLife();
        }
    }
}