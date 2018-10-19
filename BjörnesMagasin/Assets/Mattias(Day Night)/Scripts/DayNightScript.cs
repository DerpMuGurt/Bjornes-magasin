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
    int weekdays;
    int maxDays = 32;
    int months;
    public enum Weekdays
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
    public enum TimeOfDay
    {
        Day,
        Evening,
        Night,
        Morning
    }

    public Weekdays weekDays;

    public TimeOfDay timeOfDay;

    void Start()
    {
        text = text.GetComponent<Text>();
        dayText = dayText.GetComponent<Text>();
        timeText = timeText.GetComponent<Text>();
        Debug.Log(timeOfDay);
        timer = 180;
        days = 1;
        months = 2;
        weekdays = 1;
    }

    void Update()
    {
        timer += Time.deltaTime;
        switch (timeOfDay)
        {

            case TimeOfDay.Day:
                break;
            case TimeOfDay.Evening:
                break;
            case TimeOfDay.Night:
                break;
            case TimeOfDay.Morning:
                break;
        }
        switch (weekDays)
        {
            case Weekdays.Monday:
                break;
            case Weekdays.Tuesday:
                break;
            case Weekdays.Wednesday:
                break;
            case Weekdays.Thursday:
                break;
            case Weekdays.Friday:
                break;
            case Weekdays.Saturday:
                break;
            case Weekdays.Sunday:
                break;
        }

        int minutes = (int)timer / 60;
        int seconds = (int)timer % 60;
        
        dayText.text = ("Day ") + days.ToString();
        timeText.text = timeOfDay.ToString();
        text.text = weekDays.ToString();

        if (timer >= 180)
        {
            timeOfDay = TimeOfDay.Day;
            Debug.Log("It's day");
        }
        if(timer >= 360)
        {
            timeOfDay = TimeOfDay.Evening;
            Debug.Log("It's evening");
        }
        if(timer >= 540)
        {
            timeOfDay = TimeOfDay.Night;
            Debug.Log("It's night");
        }
        if(timer <= 179)
        {
            timeOfDay = TimeOfDay.Morning;
            Debug.Log("It's morning");
        }
        if (timer >= 720)
        {
            timer = 0;
            weekdays += 1;
            days += 1;
        }
        if (days == maxDays)
        {
            days = 1;
        }

        if (weekdays == 1)
        {
            weekDays = Weekdays.Monday;
        }
        if (weekdays == 2)
        {
            weekDays = Weekdays.Tuesday;
        }
        if (weekdays == 3)
        {
            weekDays = Weekdays.Wednesday;
        }
        if (weekdays == 4)
        {
            weekDays = Weekdays.Thursday;
        }
        if (weekdays == 5)
        {
            weekDays = Weekdays.Friday;
        }
        if (weekdays == 6)
        {
            weekDays = Weekdays.Saturday;
        }
        if (weekdays == 7)
        {
            weekDays = Weekdays.Sunday;
        }
        if(weekdays == 8)
        {
            weekdays = 1;
        }
    }
}