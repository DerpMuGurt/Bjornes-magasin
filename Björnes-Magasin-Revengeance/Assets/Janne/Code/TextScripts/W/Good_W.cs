using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Good_W : MonoBehaviour
{
    public Text Good_Text;

    bool active = false;

    bool MaxScore = false;

    GameObject GoodW;

    ScoreText Score;

    void Start()
    {
        Score = FindObjectOfType<ScoreText>();
        Good_Text = GameObject.FindGameObjectWithTag("Good_Text").GetComponent<Text>();
        Good_Text.text = "GOOD!";
        GoodW = GameObject.FindGameObjectWithTag("W");
        Good_Text.enabled = false;
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Good")
        {
            if (Input.GetKey(KeyCode.W) || Input.GetKey("joystick button 3"))
            {
                Good_Text.enabled = true;
                //set inactive
                //GoodW.SetActive(false);
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
