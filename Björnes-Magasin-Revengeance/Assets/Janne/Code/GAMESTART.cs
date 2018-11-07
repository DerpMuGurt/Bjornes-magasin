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
        if (Input.GetKey(KeyCode.E) || Input.GetButton("joystick button 0"))
        {
            FindObjectOfType<Movement>().enabled = false;
            Minigame.SetActive(true);
        }
    }
}
