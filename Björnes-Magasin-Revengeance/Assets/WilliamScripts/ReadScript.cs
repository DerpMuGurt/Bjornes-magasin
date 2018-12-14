using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadScript : MonoBehaviour {

    public GameObject guiObject;
    public GameObject book;
    public bool readings;

    void Start()
    {
            readings = false;
}

    void Update()
    {
        //if ( readings == true )
        //{
        //    FindObjectOfType<Movement>().enabled = false;
        
        //}
        //if (readings == true)
        //{
        //    FindObjectOfType<Movement>().enabled = true;
        
        //}

    }

    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {

            guiObject.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E) && readings == false || Input.GetKeyDown("joystick button 0"))
            {
                readings = true;
                book.SetActive(true);
            }
            else
            if (Input.GetKeyDown(KeyCode.E) && readings == true || Input.GetKeyDown("joystick button 0"))
                {
                readings = false;
                book.SetActive(false);
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            guiObject.SetActive(false);
            book.SetActive(false);
            readings = false;
        }
    }
}