using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeRotation : MonoBehaviour {

    public Transform sun;
    public float dayCycleInMinutes = 4;

    public const float seconds = 1;
    public const float minutes = 60 * seconds;
    public const float hours = 60 * minutes;
    public const float days = 24 * hours;
    public const float months = 30 * days;
    public const float years = 12 * months;

    private const float degreesPerSecond = 360 / days;
    private float degreeRotation;
    private float timeOfDay;

    void Start()
    {
        timeOfDay = 0;
        degreeRotation = degreesPerSecond * days / (dayCycleInMinutes * minutes);
        Time.timeScale = 1.0f;
    }

    void Update()
    {
        sun.Rotate = new Vector3(degreeRotation, 0, 0) * Time.deltaTime;
        timeOfDay += Time.deltaTime;
        Debug.Log(timeOfDay);

        if (Input.GetKeyDown(KeyCode.F))
        {
            minutes += 180.0f;
        }
    }
}
