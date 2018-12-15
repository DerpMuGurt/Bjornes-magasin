using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Good_Q : MonoBehaviour
{
    

    bool active = false;
    ScoreText Score;
    bool MaxScore = false;

    GameObject GoodQ;

    void Start()
    {
        Score = FindObjectOfType<ScoreText>();
    
        GoodQ = GameObject.FindGameObjectWithTag("Q");
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Good")
        {
            if (Input.GetKey(KeyCode.Q) || Input.GetKey("joystick button 1"))
            {
                
              
                Score.ScorePoints += 1;
                Score.GoodScore = true;
                Destroy(gameObject);
            }

            else if (Input.GetKey(KeyCode.R)
            || Input.GetKey("joystick button 2")
            || Input.GetKey(KeyCode.W)
            || Input.GetKey("joystick button 3")
            || Input.GetKey(KeyCode.E)
            || Input.GetKey("joystick button 0")) {

                Score.FailScore = true;
            }

        }

        if (collision.gameObject.tag == "FailBox") {

            if (Input.GetKey(KeyCode.Q) || Input.GetKey("joystick button 1")) {

                Score.FailScore = true;
                Destroy(gameObject);
            }

        }
    }

   

}
