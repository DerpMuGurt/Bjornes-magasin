using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DayNightScript : MonoBehaviour
{

    public Text text;
    public Text timeOfDayText;
    public float minutes;
    public float seconds;
    public static float timer;
    public static bool timeStarted = false;
    public enum TimeOfDay
    {
        DAY,
        EVENING,
        NIGHT,
        MORNING
    }

    public TimeOfDay timeOfDay;

    void Start()
    {
        text = GetComponent<Text>();
        Debug.Log(timeOfDay);
    }

    void Update()
    {
        if (timeStarted == true)
        {
            timer += Time.deltaTime;
        }

        switch (timeOfDay)
        {

            case TimeOfDay.DAY:
                break;
            case TimeOfDay.EVENING:
                break;
            case TimeOfDay.NIGHT:
                break;
            case TimeOfDay.MORNING:
                break;
        }


        minutes = Mathf.Floor(timer / 60);
        seconds = Mathf.RoundToInt(timer % 60);

        if (minutes < 3)
        {
            timeOfDay = TimeOfDay.DAY;
            timeOfDayText.text = timeOfDay.ToString("Day");
        }
        if (minutes < 6)
        {
            timeOfDay = TimeOfDay.EVENING;
            timeOfDayText.text = timeOfDay.ToString("Evening");
        }
        if (minutes < 9)
        {
            timeOfDay = TimeOfDay.NIGHT;
            timeOfDayText.text = timeOfDay.ToString("Night");
        }
        if (minutes > 3)
        {
            timeOfDay = TimeOfDay.MORNING;
            timeOfDayText.text = timeOfDay.ToString("Morning");
        }

        text.text = minutes.ToString("00") + ":" + seconds.ToString("00");


    }
}

