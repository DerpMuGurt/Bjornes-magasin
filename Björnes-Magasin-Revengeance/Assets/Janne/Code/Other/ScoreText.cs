using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    public float maxScorePoints;
    public float ScorePoints;
    public GameObject Minigame;
    public static bool GameComplete;
    public GameObject FinishedGame;
    public GameObject Canvas;
    public GameObject brokenBakery;
    public GameObject fixedBakery;



    void Start()
    {
        Minigame.SetActive(true);
        ScorePoints = 0;

        brokenBakery = GameObject.FindGameObjectWithTag("BrokenBakery");
        fixedBakery = GameObject.FindGameObjectWithTag("FixedBakery");

        // FinishedGame = GameObject.FindGameObjectWithTag("FinishedGame");

    }

    void Update()
    {
        brokenBakery = GameObject.FindGameObjectWithTag("BrokenBakery");
        fixedBakery = GameObject.FindGameObjectWithTag("FixedBakery");

        GameComplete = true;
        ScorePoints.ToString();
        FindObjectOfType<Movement>().enabled = false;

        if(GameComplete == true) {

            FinishedGame.SetActive(false);

        }else if(GameComplete == false) {

           // FinishedGame.SetActive(true);
        }
        

        if (ScorePoints >= maxScorePoints)
        {
           // FinishedGame.SetActive(true);
            maxScorePoints = 20;
            ScorePoints = 0;

            FindObjectOfType<Movement>().enabled = true;
            GameComplete = false;
            FinishedGame.SetActive(true);
            Minigame.SetActive(false);

          //  brokenBakery.SetActive(false);
           // fixedBakery.SetActive(true);







            //FindObjectOfType<Movement>().enabled = true;

        }

   if(maxScorePoints >= 20) {

           // FinishedGame.SetActive(true);
            GameComplete = false;
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