using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Amazing_E : MonoBehaviour
{

    public Text Amazing_Text;

    bool active = false;

    ScoreText Score;

    bool MaxScore = false;

    GameObject AmazingE;

    void Start()
    {
        Score = FindObjectOfType<ScoreText>();
        Amazing_Text = GameObject.FindGameObjectWithTag("Amazing_Text").GetComponent<Text>();
        Amazing_Text.text = "Amazing!";
        AmazingE = GameObject.FindGameObjectWithTag("E");
        Amazing_Text.enabled = false;
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Amazing")
        {
            if (Input.GetKey(KeyCode.E))
            {
                Amazing_Text.enabled = true;
                //AmazingE.SetActive(false);
                Destroy(gameObject);
                Score.ScorePoints += 10;
                //play audio here
               
            }
            StartCoroutine(MyTime());
            GameObject E;
        }
    }

    IEnumerator MyTime()
    {
        yield return new WaitForSeconds(1);
        Amazing_Text.enabled = false;
    }

}