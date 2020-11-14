using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickmanEspadachim : MonoBehaviour
{
    [SerializeField] private GameObject colliderEspadada;
    [SerializeField] private Animator stickAnim;
    [SerializeField] private AudioSource espadachimAudioS;
    [SerializeField] private AudioClip somEspadada;

    void Start()
    {
        colliderEspadada.SetActive(false);
    }

    void Update()
    {
        
    }

    public void OnClick(){
        stickAnim.SetBool("Atacando", true);
        espadachimAudioS.PlayOneShot(somEspadada);
    }

    public void AtivarEspadada(){
        colliderEspadada.SetActive(true);
    }

    public void DesativarEspadada(){
        colliderEspadada.SetActive(false);
        stickAnim.SetBool("Atacando", false);
    }
}