using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour {
    public float maxScorePoints;
    public float ScorePoints;
    public GameObject Minigame;
    public static bool GameComplete;
    public GameObject FinishedGame;
    public GameObject Canvas;
 
    Animator animator;
   

    public GameObject StandardCam;
    public GameObject RythmCam;

    public GameObject NiceImage;
    public GameObject MissImage;
 

   

    public AudioClip Right;
    public AudioClip Wrong;

    public GameObject Yellow;


    AudioSource audioSource;

    public bool GoodScore = false;
    public bool GreatScore = false;
    public bool AmazingScore = false;

    public bool FailScore = false;


    public GameObject BakingDude;
    public GameObject amazingWin;

    void Start() {

        audioSource = GetComponent<AudioSource>();
        animator = BakingDude.GetComponent<Animator>();
        

     

        Minigame.SetActive(true);
      
        ScorePoints = 0;
        //animator = GetComponent<Animator>();
       

        // FinishedGame = GameObject.FindGameObjectWithTag("FinishedGame");

    }



    void Update() {

        StandardCam.SetActive(false);
        RythmCam.SetActive(true);

        if (GoodScore == true) {
            StartCoroutine("delayFalse");
            Debug.Log("AmnimPlaying");

            animator.SetBool("KneadSuccess", true);
            Yellow.GetComponent<Image>().color = Color.green;
          NiceImage.SetActive(true);
        
            StartCoroutine("delayHit");
            audioSource.PlayOneShot(Right, 0.7F);

        }

        else if (GoodScore == false) {
            Debug.Log("AmnimPlaying");

            animator.SetBool("KneadSuccess", false);


        }


        if (FailScore == true) {
            StartCoroutine("delayFalse");
            animator.SetBool("KneadFail", true);
            Yellow.GetComponent<Image>().color = Color.red;
          MissImage.SetActive(true);
            StartCoroutine("delayMiss");
            audioSource.PlayOneShot(Wrong, 0.7F);
        }
        else if (FailScore == false) {
            Debug.Log("AmnimPlaying");

            animator.SetBool("KneadFail", false);


        }




       

        GameComplete = true;
        ScorePoints.ToString();
        FindObjectOfType<Movement>().enabled = false;

        if (GameComplete == true) {

            FinishedGame.SetActive(false);

        }
        else if (GameComplete == false) {

            // FinishedGame.SetActive(true);
        }


        if (ScorePoints >= maxScorePoints) {
            // FinishedGame.SetActive(true);
            maxScorePoints = 20;
            ScorePoints = 0;
            
            
           
            FindObjectOfType<Movement>().enabled = true;
            GameComplete = false;
            FinishedGame.SetActive(true);
            StandardCam.SetActive(true);
            RythmCam.SetActive(false);
            Minigame.SetActive(false);











            //FindObjectOfType<Movement>().enabled = true;

        }

        if (maxScorePoints >= 20) {

            // FinishedGame.SetActive(true);
            GameComplete = false;
        }


        /*if (GameComplete)
        {
            Minigame.SetActive(false);
        }
        */
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

    IEnumerator delayAnimationWin() {
        yield return new WaitForSeconds(2f);
       
    }

    IEnumerator delayFalse() {

        yield return new WaitForSeconds(0.4f);
        GoodScore = false;
        GreatScore = false;
        AmazingScore = false;
        FailScore = false;
    }


    //void OnDisable()
    //{

    //}

    //void OnEnable()
    //{
    //    ScorePoints = 0;
    //}
}