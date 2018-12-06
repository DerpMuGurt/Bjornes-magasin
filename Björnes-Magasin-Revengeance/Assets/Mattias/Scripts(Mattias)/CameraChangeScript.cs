using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChangeScript : MonoBehaviour
{

    public GameObject cameraToHide;
    public GameObject cameraToShow;
    bool isLooking;
    SelectorScript selector;

    void Start()
    {
        isLooking = false;
        selector = GetComponent<SelectorScript>();
    }


    void Update()
    {
        if (selector.gameStart == true)
        {
            LookAt();
        }
        if (selector.gameStart == false)
        {
            StopLookAt();
        }
    }

    void LookAt()
    {
        cameraToShow.gameObject.tag = "TempoCamera";
        isLooking = true;
        cameraToHide.SetActive(false);
        cameraToShow.SetActive(true);
    }

    void StopLookAt()
    {
        isLooking = false;
        cameraToHide.SetActive(true);
        cameraToShow.SetActive(false);
    }
}

