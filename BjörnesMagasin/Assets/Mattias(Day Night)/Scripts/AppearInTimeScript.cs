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
        if(dayNightScript.days == 2 || dayNightScript.days == 9 || dayNightScript.days == 16 || dayNightScript.days == 23)
        {
            redBall.SetActive(true);
        }
        if(dayNightScript.days == 3 || dayNightScript.days == 10 || dayNightScript.days == 17 || dayNightScript.days == 24)
        {
            redBall.SetActive(false);
        }
    }
}
