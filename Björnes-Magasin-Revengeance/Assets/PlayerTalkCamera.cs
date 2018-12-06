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
        isLooking = false;
    }


   void Update()
    {
        //if (DialogueManager.talking == true)
        //{
        //    LookAt();
        //}
        //if (DialogueManager.talking == false)
        //{
        //    StopLookAt();
        //}
    }

    public void LookAt()
    {

        cameraToShow.gameObject.tag = "NpcCamera";
        isLooking = true;
        cameraToHide.SetActive(false);
        cameraToShow.SetActive(true);
        objectToShow.SetActive(true);
    }

    public void StopLookAt()
    {
        isLooking = false;
        cameraToHide.SetActive(true);
        cameraToShow.SetActive(false);
        objectToShow.SetActive(false);
    }
}
