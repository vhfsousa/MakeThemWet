using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BexigaGirando : MonoBehaviour
{
    [SerializeField] private float rotationSpeed;
    [SerializeField] private Animator ballonAnim;
    [SerializeField] private GameObject bexigaParteFisica;
    [SerializeField] private Rigidbody2D bexigaParteFisicaRB;
    [SerializeField] private GameObject spawnerBexiga;

    void Start()
    {
        
    }

    void Update()
    {
        if(ballonAnim.GetBool("Estourou") == false){
            this.gameObject.transform.Rotate(new Vector3 (0, 0, rotationSpeed * Time.deltaTime));
        }
        else if (ballonAnim.GetBool("Estourou") == true){
            this.gameObject.transform.rotation = Quaternion.identity;
        }
    }

    public void Caindo(){
        ballonAnim.SetBool("Caindo", true);
    }

    public void DespawnBexiga(){
        bexigaParteFisicaRB.bodyType = RigidbodyType2D.Kinematic;
        bexigaParteFisica.gameObject.SetActive(false);
        bexigaParteFisica.transform.position = spawnerBexiga.GetComponent<SpawnerBexiga>().bexigaSpawnTransform.position;
    }
}