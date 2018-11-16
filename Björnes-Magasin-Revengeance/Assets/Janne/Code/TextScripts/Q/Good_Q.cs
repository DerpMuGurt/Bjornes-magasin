using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Good_Q : MonoBehaviour
{
    public Text Good_Text;

    bool active = false;
    ScoreText Score;

    void Start()
    {
        Score = FindObjectOfType<ScoreText>();
        Good_Text = GameObject.FindGameObjectWithTag("Good_Text").GetComponent<Text>();
        Good_Text.text = "GOOD!";
        Good_Text.enabled = false;
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        active = true;
        if (collision.gameObject.tag == "Good")
        {
            if (Input.GetKey(KeyCode.Q))
            {
                Good_Text.enabled = true;
                Destroy(gameObject);
                Score.ScorePoints += 1;
            }
            StartCoroutine(MyTime());
            active = false;
        }
    }

    IEnumerator MyTime()
    {
        yield return new WaitForSeconds(1);
        Good_Text.enabled = false;
    }

}
