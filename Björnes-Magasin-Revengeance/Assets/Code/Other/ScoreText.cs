using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    public static int scoreValue;

    void Update()
    {
        scoreValue.ToString();

        if (scoreValue > 30)
        {
            Debug.Log("ItsOVer30!");
        }
    }
}