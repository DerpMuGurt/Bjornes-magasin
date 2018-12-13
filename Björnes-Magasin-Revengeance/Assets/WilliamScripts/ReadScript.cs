using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadScript : MonoBehaviour {

    public GameObject reading;
    public GameObject guiObject;
    public GameObject book;
    bool readings;

    void Start()
    {
        reading.SetActive(false);
    }

    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            guiObject.SetActive(true);
            reading.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown("joystick button 0") && readings == false)
            {
                book.SetActive(true);
                readings = true;
            }
            if (Input.GetKeyDown(KeyCode.E)|| Input.GetKeyDown("joystick button 0") && readings == true)
            {
                book.SetActive(false);
                readings = false;
            }

        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            guiObject.SetActive(false);
            reading.SetActive(false);
            DialogueTrigger.talking = false;
        }
    }
}