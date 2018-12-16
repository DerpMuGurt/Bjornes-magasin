using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadScript : MonoBehaviour {

    public GameObject reading;
    public GameObject guiObject;

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