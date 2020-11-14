using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FreezeButton : MonoBehaviour
{
    [SerializeField] private float tempoCongelamento;
    [SerializeField] private GameObject freezeImage;
    [SerializeField] private Button freezeButton;
    [SerializeField] private AudioSource freezeSound;
    [SerializeField] private AudioClip freezeButtonSound;

    void Start()
    {

    }

    void Update()
    {

    }

    public void OnClick(){
        freezeButton.interactable = false;
        freezeSound.PlayOneShot(freezeButtonSound);
        freezeImage.SetActive(true);
        Time.timeScale = 0.5f;
        Invoke ("TempoNormal", tempoCongelamento);
    }

    private void TempoNormal(){
        freezeButton.interactable = true;
        freezeImage.SetActive(false);
        Time.timeScale = 1;
    }
}