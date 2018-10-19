using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockAnimatorScript : MonoBehaviour {

    DayNightScript dayNightScript;
    public Transform minutes, seconds;

    private const float
        minutesToDegrees = 360f / 12f,
        secondsToDegrees = 360f / 60f;

    public bool analog;

    void Start()
    {

    }

    void Update()
    {
        if (analog)
        {
            System.TimeSpan timespan = System.DateTime.Now.TimeOfDay;
            minutes.localRotation =
                Quaternion.Euler(0f, 0f, (float)timespan.TotalMinutes * -minutesToDegrees);
            seconds.localRotation =
                Quaternion.Euler(0f, 0f, (float)timespan.TotalSeconds * -secondsToDegrees);
        }
        else
        {
            System.DateTime time = System.DateTime.Now;
            minutes.localRotation = Quaternion.Euler(0f, 0f, time.Minute * -minutesToDegrees);
            seconds.localRotation = Quaternion.Euler(0f, 0f, time.Second * -secondsToDegrees);
        }
    }

}
