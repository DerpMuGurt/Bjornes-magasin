using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GAMESTART : MonoBehaviour
{
    public GameObject Minigame;

    void Start()
    {
        Minigame.SetActive(false); 
    }

    void OnTriggerStay(Collider other)
    {
        if (Input.GetKey(KeyCode.E) && other.tag == "Player" || Input.GetButton("joystick button 0") && other.tag == "Player")
        {
            FindObjectOfType<Movement>().enabled = false;
            Minigame.SetActive(true);
        }
    }
}
