using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Great_Q : MonoBehaviour
{
    public Text Great_Text;

    bool active = false;
    ScoreText Score;
    bool MaxScore = false;

    GameObject GreatQ;

    void Start()
    {
        Score = FindObjectOfType<ScoreText>();
        Great_Text = GameObject.FindGameObjectWithTag("Great_Text").GetComponent<Text>();
        Great_Text.text = "Great!";
        GreatQ = GameObject.FindGameObjectWithTag("Q");
        Great_Text.enabled = false;
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Great")
        {
            if (Input.GetKey(KeyCode.Q) || Input.GetKey("joystick button 1"))
            {
                Great_Text.enabled = true;
                //set inactive
                //GreatQ.SetActive(false);
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