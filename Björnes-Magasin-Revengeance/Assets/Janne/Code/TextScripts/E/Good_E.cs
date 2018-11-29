using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Good_E : MonoBehaviour
{

    public Text Good_Text;

    bool active = false;

    ScoreText Score;

    GameObject GoodE;

    bool MaxScore = false;

    void Start()
    {
        Score = FindObjectOfType<ScoreText>();
        Good_Text = GameObject.FindGameObjectWithTag("Good_Text").GetComponent<Text>();
        Good_Text.text = "GOOD!";
        GoodE = GameObject.FindGameObjectWithTag("E");
        Good_Text.enabled = false;
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Good")
        {
            if (Input.GetKey(KeyCode.E))
            {
                Good_Text.enabled = true;
                //set inactive
                //GoodE.SetActive(false);
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