using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DayNightScript : MonoBehaviour
{

    public Text text;
    public Text dayText;
    public Text clockText;
    public Light dayLight;
    public float timer = 0;
    public int days;
    int weekNumber;
    int maxDays = 32;
    int months;
    Color orange;
    Color darkOrange;
    Color brightYellow;
    Color dayColor = Color.white;
    Color nightColor = Color.black;

    public enum Weekdays //enumerates weekdays
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
    public enum TimeOfDay //enumerates the phase of the day
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
        DontDestroyOnLoad(this.gameObject);
        text = text.GetComponent<Text>();
        dayText = dayText.GetComponent<Text>();
        dayLight = dayLight.GetComponent<Light>();
        clockText = clockText.GetComponent<Text>();
        orange = new Color32(255, 135, 0, 255);
        darkOrange = new Color32(255, 30, 0, 255);
        brightYellow = new Color32(255, 244, 214, 255);
        Debug.Log(timeOfDay);
        timer = 160;
        days = 1;
        months = 2;
        weekNumber = 1;

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


        int minutes = (int)timer / 60; //clock that displays minutes
        int seconds = (int)timer % 60; //clock that displays seconds
        {
            dayText.text = ("Day ") + days.ToString();
            clockText.text = minutes.ToString("00") + ":" + seconds.ToString("00");
            text.text = weekDays.ToString();
        }
        if (timer >= 180)
        {
            timeOfDay = TimeOfDay.Day;
            dayLight.color = brightYellow;
            Debug.Log("It's day");
        }
        if (timer >= 360)
        {
            timeOfDay = TimeOfDay.Evening;
            dayLight.color = orange;
            Debug.Log("It's evening");
        }
        if (timer >= 540)
        {
            timeOfDay = TimeOfDay.Night;
            dayLight.color = nightColor;
            Debug.Log("It's night");
        }
        if (timer <= 179)
        {
            timeOfDay = TimeOfDay.Morning;
            dayLight.color = darkOrange;
            Debug.Log("It's morning");
        }

        if (timer >= 720)
        {
            timer = 0;
            weekNumber += 1;
            days += 1;
        }
        if (days == maxDays)
        {
            days = 1;
        }

        if (weekNumber == 1)
        {
            weekDays = Weekdays.Monday;
        }
        if (weekNumber == 2)
        {
            weekDays = Weekdays.Tuesday;
        }
        if (weekNumber == 3)
        {
            weekDays = Weekdays.Wednesday;
        }
        if (weekNumber == 4)
        {
            weekDays = Weekdays.Thursday;
        }
        if (weekNumber == 5)
        {
            weekDays = Weekdays.Friday;
        }
        if (weekNumber == 6)
        {
            weekDays = Weekdays.Saturday;
        }
        if (weekNumber == 7)
        {
            weekDays = Weekdays.Sunday;
        }
        if (weekNumber == 8)
        {
            weekNumber = 1;
        }
    }
}