using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Amazing_W : MonoBehaviour
{
    public Text Amazing_Text;

    bool active = false;

    ScoreText Score;

    bool MaxScore = false;

    GameObject AmazingW;

    void Start()
    {
        Score = FindObjectOfType<ScoreText>();
        Amazing_Text = GameObject.FindGameObjectWithTag("Amazing_Text").GetComponent<Text>();
        Amazing_Text.text = "Amazing!";
        AmazingW = GameObject.FindGameObjectWithTag("W");
        Amazing_Text.enabled = false;
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Amazing")
        {
           if (Input.GetKey(KeyCode.W))
           {
             Amazing_Text.enabled = true;
             //set inactive
             //AmazingW.SetActive(false);
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
