﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Great_R : MonoBehaviour
{
    public Text Great_Text;

    bool active = false;

    bool MaxScore = false;

    GameObject GreatR;

    ScoreText Score;

    void Start()
    {
        Score = FindObjectOfType<ScoreText>();
        Great_Text = GameObject.FindGameObjectWithTag("Great_Text").GetComponent<Text>();
        GreatR = GameObject.FindGameObjectWithTag("R");
        Great_Text.text = "Great!";
        Great_Text.enabled = false;
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Great")
        {
            if (Input.GetKey(KeyCode.R) || Input.GetKey("joystick button 2"))
            {
                Great_Text.enabled = true;
                //set inactive
                //GreatR.SetActive(false);
                Score.ScorePoints += 5;
                //play audio here
                Destroy(gameObject);
            }
            StartCoroutine(MyTime());
        }
    }


    IEnumerator MyTime()
    {
        yield return new WaitForSeconds(1);
        Great_Text.enabled = false;
    }

}
