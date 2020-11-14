using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlGame : MonoBehaviour
{
    [SerializeField] private int playerPoints;
    [SerializeField] private int playerLife;
    [SerializeField] private Text scoreText;
    [SerializeField] private Button slowDownButton;
    [SerializeField] private Button telaAzul;
    [SerializeField] private Button telaVermelho;
    [SerializeField] private Button telaVerde;
    [SerializeField] private Button telaAmarelo;
    [SerializeField] private SpriteRenderer fundoJogo;
    [SerializeField] private Sprite telaColorida;
    [SerializeField] private Sprite telaPB;
    [SerializeField] private GameObject deadThings;
    [SerializeField] private AudioSource gameMusic;

    void Start()
    {
        fundoJogo.sprite = telaColorida;
        playerPoints = 0;
        playerLife = 1;
        Time.timeScale = 1;
    }

    void Update()
    {
        scoreText.text = (playerPoints.ToString());

        if(playerLife <= 0){
            Death();
        }
    }

    public void AddPoints(){
        playerPoints ++;
    }

    public void LoseLife(){
        playerLife -= 1;
    }

    public void Death(){
        Time.timeScale = 0;
        gameMusic.enabled = false;
        slowDownButton.interactable = false;
        telaAzul.interactable = false;
        telaVermelho.interactable = false;
        telaVerde.interactable = false;
        telaAmarelo.interactable = false;
        fundoJogo.sprite = telaPB;
        deadThings.SetActive(true);
    }
}