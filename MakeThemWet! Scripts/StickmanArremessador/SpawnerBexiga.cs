using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerBexiga : MonoBehaviour
{
    [SerializeField] private GameObject bexiga;
    public Transform bexigaSpawnTransform;

    public void SpawnBexiga(){
        bexiga.gameObject.SetActive(true);
    }
}