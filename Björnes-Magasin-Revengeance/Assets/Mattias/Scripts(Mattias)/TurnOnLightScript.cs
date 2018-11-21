using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOnLightScript : MonoBehaviour
{
    DayNightScript dayNight;
    public Light streetLight;

    void Start()
    {
        dayNight = GetComponent<DayNightScript>();
        streetLight = GetComponent<Light>();
        streetLight.gameObject.SetActive(false);
    }
    void Update()
    {
        if (dayNight.timer >= 540)
        {
            streetLight.gameObject.SetActive(true);
            print(streetLight);
        }
        if (dayNight.timer >= 0 || dayNight.timer <= 539)
        {
            streetLight.gameObject.SetActive(false);
            print(streetLight);
        }
    }
}