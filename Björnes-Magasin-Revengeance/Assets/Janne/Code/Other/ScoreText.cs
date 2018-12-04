using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    public float maxScorePoints;
    public float ScorePoints;
    public GameObject Minigame;
    public bool GameComplete = false;
    public GameObject FinishedGame;
    public GameObject Canvas;
    
  

    void Start()
    {
        Minigame.SetActive(true);
        ScorePoints = 0;
      
        
        // FinishedGame = GameObject.FindGameObjectWithTag("FinishedGame");

    }

    void Update()
    {
        ScorePoints.ToString();
        FindObjectOfType<Movement>().enabled = false;

        if (ScorePoints > maxScorePoints)
        {
           // FinishedGame.SetActive(true);
            maxScorePoints = 20;
            ScorePoints = 0;

       

            Minigame.SetActive(false);
            FinishedGame.SetActive(true);
            FindObjectOfType<Movement>().enabled = true;

        }

    if(maxScorePoints >= 20) {

            FinishedGame.SetActive(true);
            FindObjectOfType<Movement>().enabled = true;

        }


        /*if (GameComplete)
        {
            Minigame.SetActive(false);
        }
        */
    }

    //void OnDisable()
    //{
        
    //}

    //void OnEnable()
    //{
    //    ScorePoints = 0;
    //}
}