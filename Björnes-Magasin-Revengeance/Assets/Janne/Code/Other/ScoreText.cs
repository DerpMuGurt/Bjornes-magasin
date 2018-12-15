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

    public GameObject NiceImage;
    public GameObject MissImage;

    Animator animator;

    AudioSource audioS;
    public AudioClip GoodSound;
    public AudioClip MissSound;

    public GameObject MainCam;
    public GameObject RythmCam;

    public bool GoodScore = false;
    public bool FailScore = false;

    public GameObject Yellow;

    public GameObject bakingDude;





    void Start()
    {
        Minigame.SetActive(true);

        animator = bakingDude.GetComponent<Animator>();
        audioS = GetComponent<AudioSource>();

        ScorePoints = 0;


        // FinishedGame = GameObject.FindGameObjectWithTag("FinishedGame");

    }

    void Update()
    {

        MainCam.SetActive(false);
        RythmCam.SetActive(true);


        if (GoodScore == true) {

           StartCoroutine("delayFalse");
            animator.SetBool("KneadSuccess", true);
            audioS.PlayOneShot(GoodSound, 0.7F);
           Yellow.GetComponent<Image>().color = Color.green;
           NiceImage.SetActive(true);
           StartCoroutine("delayHit");
        }

        else if (GoodScore == false) {
            animator.SetBool("KneadSuccess", false);

        }


        if (FailScore == true) {
            StartCoroutine("delayFalse");
            animator.SetBool("KneadFail", true);
            audioS.PlayOneShot(MissSound, 0.7F);
            Yellow.GetComponent<Image>().color = Color.red;
           MissImage.SetActive(true);
            StartCoroutine("delayMiss");

        }
        else if (FailScore == false) {


            animator.SetBool("KneadFail", false);


        }















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

            MainCam.SetActive(true);
            RythmCam.SetActive(false);

            FindObjectOfType<Movement>().enabled = true;
            GameComplete = false;
            FinishedGame.SetActive(true);
            Minigame.SetActive(false);


        }

   if(maxScorePoints >= 20) {

           // FinishedGame.SetActive(true);
            GameComplete = false;
        }


    
    }

    IEnumerator delayFalse() {

        yield return new WaitForSeconds(0.4f);
        GoodScore = false;

        FailScore = false;
    }

    IEnumerator delayHit() {
        yield return new WaitForSeconds(0.5f);
        Yellow.GetComponent<Image>().color = Color.yellow;
        NiceImage.SetActive(false);

    }

    IEnumerator delayMiss() {
        yield return new WaitForSeconds(0.5f);
        Yellow.GetComponent<Image>().color = Color.yellow;
        MissImage.SetActive(false);

    }



}