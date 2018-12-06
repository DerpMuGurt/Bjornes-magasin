using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTalkCamera : MonoBehaviour {

    public GameObject cameraToHide;
    public GameObject cameraToShow;
    public GameObject objectToShow;
    bool isLooking;

    void Start()
    {

        objectToShow = GameObject.FindWithTag("PlayerGraphics");
    }


   void Update()
    {

    }

    public void LookAt()
    {
        cameraToHide.SetActive(false);
        cameraToShow.SetActive(true);
        objectToShow.SetActive(true);
        if (DialogueManager.talking == false)
        {
            StopLookAt();
        }
    }

    public void StopLookAt()
    {
        cameraToHide.SetActive(true);
        cameraToShow.SetActive(false);
    }
}
