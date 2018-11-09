using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour {

    public GameObject guiObject;
    public GameObject objectToHide;
    public GameObject objectToShow;
    bool isLooking;
    bool dontShowObject;


    void Start()
    {
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
                isLooking = true;
                objectToHide.SetActive(false);
                objectToShow.SetActive(true);
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
                isLooking = false;
                objectToHide.SetActive(true);
                objectToShow.SetActive(false);
                guiObject.SetActive(false);
                FindObjectOfType<Movement>().enabled = true;
            }
        }
    }

    void OnTriggerExit()
    {
        guiObject.SetActive(false);
    }
}
