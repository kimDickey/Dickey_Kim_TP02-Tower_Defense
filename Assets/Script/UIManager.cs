using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;
    public Text txtTime;
    public bool isGameOver { get; private set; } = false;
    public Transform spawnLocation;
    public GameObject prefabEnnemi1;
    int timer;
    float timerDebut;
    //float spawnInterval = 0.8f;
    public GameObject txtGameOver;
    public Button btnPause;
    public Button btnPlay;

    public Text txtPointDeVie;
    public bool isPaused = false;
    public int argent = 500;
    int nbVie = 5;
    public static bool uiIsOpen;
    public Text txtargent;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        // temps du timer d�part
        timerDebut = 0;
        // quand qu'on clique sur le bouton pause et le jeu se met en pause
        btnPause.onClick.AddListener(PauseTime);
        // quand qu'on clique sur le jeu se remet en marche
        btnPlay.onClick.AddListener(ResumePartie);

    }

    // Update is called once per frame
    void Update()
    {
        // debuter le timer
        timerDebut = timerDebut + Time.deltaTime;
        TimeSpan timer = TimeSpan.FromSeconds(timerDebut);
        // calculer le temps en minutes:secondes
        txtTime.text = timer.ToString(@"mm\:ss\:ff");
        Debug.Log(timer.ToString(@"mm\:ss\:ff"));
        // afficher l'argent fait dans le text
        txtargent.text = argent.ToString() + "$";
    }
    void PauseTime()
    {
        // v�rifier si le temps est en pause ou non
        Time.timeScale = 0f;
        isPaused = true;

    }

    void ResumePartie()
    {
        // reprend la partie si le temps n'est plus en pause
        Time.timeScale = 1f;
        isPaused = false;
    }

    public void PointDeViePerdu()
    {
        // point de vie
        nbVie -= 1;
        txtPointDeVie.text = nbVie.ToString();
        // si le nombre de point est �gale 0 la partie est terminer
        if (nbVie == 0)
        {
            GameOver();
        }

    }
    // Fin de la partie
    public void GameOver()
    {
        isGameOver = true;
        txtGameOver.SetActive(true);
        Time.timeScale = 0f;
    }
}