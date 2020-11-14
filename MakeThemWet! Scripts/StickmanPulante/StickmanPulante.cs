using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickmanPulante : MonoBehaviour
{
    [SerializeField] private Rigidbody2D stickmanPulante;
    [SerializeField] private AudioSource jumpingStickmanAudioS;
    [SerializeField] private AudioClip jumpingAudioClip;
    [SerializeField] private float jumpForce;
    [SerializeField] private bool onGround;
    void Start()
    {
        onGround = true;
    }

    void Update()
    {
        
    }

    public void OnClick(){
        if(onGround == true){
            jumpingStickmanAudioS.PlayOneShot(jumpingAudioClip);
            onGround = false;
            stickmanPulante.AddForce(Vector3.up * jumpForce, ForceMode2D.Impulse);
        }
    }

    public void OnCollisionEnter2D(Collision2D col){
        if(col.gameObject.CompareTag("Chão")){
            onGround = true;
        }
    }
}