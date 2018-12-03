using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class talkCamera : MonoBehaviour {

    public GameObject cameraToHide;
    public GameObject cameraToShow;
    public GameObject objectToHide;
    bool isLooking;

    void Start()
    {

        objectToHide = GameObject.FindWithTag("PlayerGraphics");
        isLooking = false; 
    }


    void Update()
    {
        if (DialogueManager.talking == true)
        {
            LookAt();
        }
        if (DialogueManager.talking == false)
        {
            StopLookAt();
        }
    }

    void LookAt()
    {

        cameraToShow.gameObject.tag = "NpcCamera";
        isLooking = true;
                cameraToHide.SetActive(false);
                cameraToShow.SetActive(true);
        objectToHide.SetActive(false);
    }

    void StopLookAt()
    {
                isLooking = false;
                cameraToHide.SetActive(true);
                cameraToShow.SetActive(false);
        objectToHide.SetActive(true);
    }
}
