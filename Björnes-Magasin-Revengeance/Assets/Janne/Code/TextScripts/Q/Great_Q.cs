using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Great_Q : MonoBehaviour
{
    public Text Great_Text;

    bool active = false;

    void Start()
    {
        Great_Text.text = "Great!";
        Great_Text.enabled = false;
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        active = true;
        if (collision.gameObject.tag == "Great")
        {
            if (Input.GetKey(KeyCode.Q))
            {
                Great_Text.enabled = true;
                Destroy(gameObject);
                ScoreText.scoreValue += 5;
            }
            StartCoroutine(MyTime());
            active = false;
        }
    }

    IEnumerator MyTime()
    {
        yield return new WaitForSeconds(1);
        Great_Text.enabled = false;
    }
}
