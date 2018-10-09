using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppearInTimeScript : MonoBehaviour {

    public GameObject ball;
    public GameObject redBall;
    DayNightScript dayNightScript;

    void Start()
    {
        dayNightScript = GetComponent<DayNightScript>();
        ball.SetActive(false);
        redBall.SetActive(false);
    }
    void Update()
    {
        if(dayNightScript.timer >= 180)
        {
            ball.SetActive(true);
        }
        if(dayNightScript.timer <= 179)
        {
            ball.SetActive(false);
        }
        if (dayNightScript.timer >= 360)
        {
            ball.SetActive(false);
        }
        if(dayNightScript.days == 2)
        {
            redBall.SetActive(true);
        }
        if(dayNightScript.days == 3)
        {
            redBall.SetActive(false);
        }
    }
}
