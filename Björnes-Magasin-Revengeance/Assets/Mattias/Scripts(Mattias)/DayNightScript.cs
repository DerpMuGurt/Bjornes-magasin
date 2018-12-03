using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DayNightScript : MonoBehaviour
{

    public Text text;
    public Text dayText;
    public Text timeText;
    public Text clockText;
    public Light dayLight;
    public float timer = 0;
    public int days;
    int weekNumber;
    int maxDays = 32;
    int months;
    public Color eveningColor = new Color32(236, 117, 72, 255);
    public Color morningColor = new Color32(255, 102, 179, 255);
    public Color dayColor = new Color32(255, 255, 255, 255);
    public Color nightColor = new Color32(0, 0, 128, 255);
    public Color dayTrans = new Color32(245, 198, 112, 255);
    public Color eveningTrans = new Color32(221, 66, 129, 255);
    public Color nightTrans = new Color32(166, 73, 142, 255);
    public Color morningTrans = new Color32(255, 192, 203, 255);
    public Color currentColor;
    public static bool isDay = true;
    public static bool isNight = false;

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
        timeText = timeText.GetComponent<Text>();
        dayLight = dayLight.GetComponent<Light>();
        Debug.Log(timeOfDay);
        timer = 210;
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
            timeText.text = timeOfDay.ToString();
            clockText.text = minutes.ToString("00") + ":" + seconds.ToString("00");
            text.text = weekDays.ToString();
            currentColor = dayLight.color;
        }
        if (timer >= 0)
        {
            timeOfDay = TimeOfDay.Night;
            dayLight.color = nightColor;
        }

        if (timer >= 120)
        {
            dayLight.color = nightTrans;
        }

        if (timer >= 210)
        {
            timeOfDay = TimeOfDay.Morning;
            dayLight.color = morningColor;
            isNight = false;
        }

        if (timer >= 300)
        {
            dayLight.color = morningTrans;
        }

        if (timer >= 390)
        {
            timeOfDay = TimeOfDay.Day;
            dayLight.color = dayColor;
            isDay = true;
        }

        if (timer >= 480)
        {
            dayLight.color = dayTrans;
        }

        if (timer >= 570)
        {
            timeOfDay = TimeOfDay.Evening;
            dayLight.color = eveningColor;
            isDay = false;
        }

        if (timer >= 660)
        {
            dayLight.color = eveningTrans;
            isNight = true;
            
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