using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Great_E : MonoBehaviour
{
    public Text Great_Text;

    bool active = false;

    bool MaxScore = false;

    GameObject GreatE;

    ScoreText Score;

    void Start()
    {
        Score = FindObjectOfType<ScoreText>();
        Great_Text = GameObject.FindGameObjectWithTag("Great_Text").GetComponent<Text>();
        GreatE = GameObject.FindGameObjectWithTag("E");
        Great_Text.text = "Great!";
        Great_Text.enabled = false;
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Great")
        {
            if (Input.GetKey(KeyCode.E))
            {
                Great_Text.enabled = true;
                //set inactive
                GreatE.SetActive(false);
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
