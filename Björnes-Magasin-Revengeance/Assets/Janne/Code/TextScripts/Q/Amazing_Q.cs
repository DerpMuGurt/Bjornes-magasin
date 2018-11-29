using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Amazing_Q : MonoBehaviour
{
    public Text Amazing_Text;

    bool active = false;
    ScoreText Score;

    bool MaxScore = false;

    GameObject AmazingQ;

    void Start()
    {
        Score = FindObjectOfType<ScoreText>();
        Amazing_Text = GameObject.FindGameObjectWithTag("Amazing_Text").GetComponent<Text>();
        Amazing_Text.text = "Amazing!";
        AmazingQ = GameObject.FindGameObjectWithTag("Q");
        Amazing_Text.enabled = false;
    }


    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Amazing")
        {
            if (Input.GetKey(KeyCode.Q))
            {
                Amazing_Text.enabled = true;
                //set inactive
                //AmazingQ.SetActive(false);
                Score.ScorePoints += 10;
                //play audio here
                Destroy(gameObject);
            }
            StartCoroutine(MyTime());
        }
    }
    IEnumerator MyTime()
    {
        yield return new WaitForSeconds(1);
        Amazing_Text.enabled = false;
    }

}
