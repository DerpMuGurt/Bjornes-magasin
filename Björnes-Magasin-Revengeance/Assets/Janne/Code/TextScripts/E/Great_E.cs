﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Great_E : MonoBehaviour
{
    public Text Great_Text;

    bool active = false;

    ScoreText Score;

    void Start()
    {
        Score = FindObjectOfType<ScoreText>();
        Great_Text = GameObject.FindGameObjectWithTag("Great_Text").GetComponent<Text>();
        Great_Text.text = "Great!";
        Great_Text.enabled = false;
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        active = true;
        if (collision.gameObject.tag == "Great")
        {
            if (Input.GetKey(KeyCode.E))
            {
                Great_Text.enabled = true;
                Destroy(gameObject);
                Score.ScorePoints += 5;
            }
            StartCoroutine(MyTime());
            active = false;
            GameObject E;
        }
    }

    IEnumerator MyTime()
    {
        yield return new WaitForSeconds(1);
        Great_Text.enabled = false;
    }

}
