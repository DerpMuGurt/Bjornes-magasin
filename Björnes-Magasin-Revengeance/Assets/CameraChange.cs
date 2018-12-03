using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour {

    public GameObject guiObject;
    public GameObject cameraToHide;
    public GameObject cameraToShow;
    public GameObject objectToHide;
    bool isLooking;
    bool dontShowObject;


    void Start()
    {
        objectToHide = GameObject.FindWithTag("PlayerGraphics");
        isLooking = false;
        guiObject.SetActive(false);

    }

    void OnTriggerStay(Collider other)
    {
        guiObject.SetActive(true);
        if (other.gameObject.tag == "Player")
        {
            if(isLooking == false)
            {
                LookAt();
            }
            if (isLooking == true)
            {
                StopLookAt();
            }
        }

    }

    void LookAt()
    {
        if (Input.GetKeyDown(KeyCode.E) && isLooking == false)
        {
            if (guiObject.activeInHierarchy == true)
            {
                objectToHide.SetActive(false);
                isLooking = true;
                cameraToHide.SetActive(false);
                cameraToShow.SetActive(true);
                guiObject.SetActive(false);
                FindObjectOfType<Movement>().enabled = false;
            }
        }

    }

    void StopLookAt()
    {
        if (Input.GetKeyDown(KeyCode.E) && isLooking == true)
        {
            if (guiObject.activeInHierarchy == true)
            {
                objectToHide.SetActive(true);
                isLooking = false;
                cameraToHide.SetActive(true);
                cameraToShow.SetActive(false);
                guiObject.SetActive(false);
                FindObjectOfType<Movement>().enabled = true;
            }
        }
    }

    void OnTriggerExit()
    {
        FindObjectOfType<Movement>().enabled = true;
        guiObject.SetActive(false);
    }
}
