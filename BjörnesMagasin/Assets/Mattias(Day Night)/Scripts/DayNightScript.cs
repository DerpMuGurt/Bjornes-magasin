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
    int maxDays = 29;
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
            days += 1;
        }
        if (days == maxDays)
        {
            days = 1;
        }

        if (days == 1 || days == 8 || days == 15 || days == 22)
        {
            weekDays = Weekdays.Monday;
        }
        if (days == 2 || days == 9 || days == 16 || days == 23)
        {
            weekDays = Weekdays.Tuesday;
        }
        if (days == 3 || days == 10 || days == 17 || days == 24)
        {
            weekDays = Weekdays.Wednesday;
        }
        if (days == 4 || days == 11 || days == 18 || days == 25)
        {
            weekDays = Weekdays.Thursday;
        }
        if (days == 5 || days == 12 || days == 19 || days == 26)
        {
            weekDays = Weekdays.Friday;
        }
        if (days == 6 || days == 13 || days == 20 || days == 27)
        {
            weekDays = Weekdays.Saturday;
        }
        if (days == 7 || days == 14 || days == 21 || days == 28)
        {
            weekDays = Weekdays.Sunday;
        }
    }
}