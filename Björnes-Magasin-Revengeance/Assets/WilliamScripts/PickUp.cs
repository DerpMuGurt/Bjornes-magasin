using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour {

    public GameObject guiObject;
    public GameObject thisObject;
    public GameObject objectToShow;
    bool dontShowObject;


    void Start()
    {
    
        guiObject.SetActive(false);

    }

    void OnTriggerStay(Collider other)
    {
        guiObject.SetActive(true);
        if (other.gameObject.tag == "Player" && Input.GetKeyDown(KeyCode.E))
            {
            if (guiObject.activeInHierarchy == true)
            {
                thisObject.SetActive(false);
                objectToShow.SetActive(true);
                guiObject.SetActive(false);
            }
        }
    }

    void OnTriggerExit()
    {
        guiObject.SetActive(false);
    }
}
