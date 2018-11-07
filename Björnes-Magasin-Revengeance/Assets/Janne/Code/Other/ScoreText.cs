using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    public static int scoreValue;
    public GameObject Minigame;

    void Start()
    {
        scoreValue = 0;
    }

    void Update()
    {
        scoreValue.ToString();

        if (scoreValue > 30)
        {
            Debug.Log("ItsOVer30!");
            Minigame.SetActive(false);
            FindObjectOfType<Movement>().enabled = true;
        }
    }
}