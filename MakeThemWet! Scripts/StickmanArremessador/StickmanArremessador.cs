using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickmanArremessador : MonoBehaviour
{
    private float delay;
    [SerializeField] private float tempoDelay;
    [SerializeField] private float tempoInicial;
    [SerializeField] private GameObject bexigaSpawner;
    [SerializeField] private Animator arremessadorAnim;
    [SerializeField] private AudioSource arremessador;
    [SerializeField] private AudioClip arremesso;
    
    void Start()
    {

    }

    void Update()
    {
        delay -= Time.deltaTime;

        if(delay <= 0 && Time.timeSinceLevelLoad > tempoInicial){
            arremessadorAnim.SetBool("Arremessar", true);
        }
    }

    void ArremessarBexiga(){
        arremessador.PlayOneShot(arremesso);
        bexigaSpawner.gameObject.GetComponent<SpawnerBexiga>().SpawnBexiga();
        delay = tempoDelay;
    }

    void VoltarIdle(){
        arremessadorAnim.SetBool("Arremessar", false);
    }
}