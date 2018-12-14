using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Good_R: MonoBehaviour
{
    bool active = false;

    ScoreText Score;

    Animator animator;

    bool MaxScore = false;

    Collider myCollider;

    void Start() {
        myCollider = gameObject.GetComponent<Collider>();
        //myCollider.enabled = true;
        animator = GetComponent<Animator>();
        Score = FindObjectOfType<ScoreText>();

    }

    void OnTriggerStay2D(Collider2D collision) {
        if (collision.gameObject.tag == "Good") {
            if (Input.GetKey(KeyCode.R) || Input.GetKey("joystick button 2")) {

                //set inactive
                Score.ScorePoints += 2;
                Score.GoodScore = true;
                //play audio here
                //myCollider.enabled = false;

                //StartCoroutine("Destroy");
                Destroy(gameObject);
            }

            else if (Input.GetKey(KeyCode.Q)
                || Input.GetKey("joystick button 1")
                || Input.GetKey(KeyCode.E)
                || Input.GetKey("joystick button 0")
                || Input.GetKey(KeyCode.W)
                || Input.GetKey("joystick button 3")) {
                Debug.Log("WrongButton!");
                Score.FailScore = true;
            }

        }

        if (collision.gameObject.tag == "FailBox") {
            if (Input.GetKey(KeyCode.R) || Input.GetKey("joystick button 2")) {
                Score.FailScore = true;
                Destroy(gameObject);
            }
        }


    }


    IEnumerator Destroy() {
        yield return new WaitForSeconds(3);
        Destroy(gameObject);
    }

}
