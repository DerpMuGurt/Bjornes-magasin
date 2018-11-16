using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    public float maxScorePoints;
    public float ScorePoints;
    public GameObject Minigame;

    void Start()
    {
        ScorePoints = 0;
    }

    void Update()
    {
        ScorePoints.ToString();

        if (ScorePoints >= maxScorePoints)
        {

            Minigame.gameObject.SetActive(false);
        }


    }

    void OnDisable()
    {
        FindObjectOfType<Movement>().enabled = true;
     //   ScorePoints = 0;
    }

    //void OnEnable()
    //{
    //    ScorePoints = 0;
    //}
}