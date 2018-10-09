using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DayNightScript : MonoBehaviour
{

    public Text text;
    public Text dayText;
    public Text timeText;
    public float timer = 0;
    public int days;
    int maxDays = 31;
    int months;
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
        text = text.GetComponent<Text>();
        dayText = dayText.GetComponent<Text>();
        timeText = timeText.GetComponent<Text>();
        Debug.Log(timeOfDay);
        timeOfDay = TimeOfDay.DAY;
        days = 1;
        
    }

    void Update()
    {
        timer += Time.deltaTime;
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

        int minutes = (int)timer / 60;
        int seconds = (int)timer % 60;

        text.text = minutes.ToString("00") + ":" + seconds.ToString("00");
        dayText.text = ("Day ") + days.ToString();
        timeText.text = timeOfDay.ToString();

        if (timer >= 180)
        {
            timeOfDay = TimeOfDay.DAY;
            Debug.Log("It's day");
        }
        if(timer >= 360)
        {
            timeOfDay = TimeOfDay.EVENING;
            Debug.Log("It's evening");
        }
        if(timer >= 540)
        {
            timeOfDay = TimeOfDay.NIGHT;
            Debug.Log("It's night");
        }
        if(timer <= 179)
        {
            timeOfDay = TimeOfDay.MORNING;
            Debug.Log("It's morning");
        }
        if (timer >= 720)
        {
            timer = 0;
            days += 1;
        }
        if (days == maxDays)
        {
            days = 0;
        }
    }
}