using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Amazing_E : MonoBehaviour
{

    public Text Amazing_Text;

    bool active = false;

    ScoreText Score;

    void Start()
    {
        Score = FindObjectOfType<ScoreText>();
        Amazing_Text = GameObject.FindGameObjectWithTag("Amazing_Text").GetComponent<Text>();
        Amazing_Text.text = "Amazing!";
        Amazing_Text.enabled = false;
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        active = true;
        if (collision.gameObject.tag == "Amazing")
        {
            if (Input.GetKey(KeyCode.E))
            {
                Amazing_Text.enabled = true;
                Destroy(gameObject);
                Score.ScorePoints += 10;
            }
            StartCoroutine(MyTime());
            active = false;
        }
    }

    IEnumerator MyTime()
    {
        yield return new WaitForSeconds(1);
        Amazing_Text.enabled = false;
    }

}