using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Good_Q : MonoBehaviour
{
    public Text Good_Text;

    bool active = false;
    ScoreText Score;
    bool MaxScore = false;

    GameObject GoodQ;

    void Start()
    {
        Score = FindObjectOfType<ScoreText>();
        Good_Text = GameObject.FindGameObjectWithTag("Good_Text").GetComponent<Text>();
        Good_Text.text = "GOOD!";
        Good_Text.enabled = false;
        GoodQ = GameObject.FindGameObjectWithTag("Q");
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Good")
        {
            if (Input.GetKey(KeyCode.Q) || Input.GetKey("joystick button 1"))
            {
                Good_Text.enabled = true;
                //set inactive
                //GoodQ.SetActive(false);
                Score.ScorePoints += 1;
                //play audio here
                Destroy(gameObject);
            }
            StartCoroutine(MyTime());
        }
    }

    IEnumerator MyTime()
    {
        yield return new WaitForSeconds(1);
        Good_Text.enabled = false;
    }

}
