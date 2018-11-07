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

    void OnTriggerEnter(Collider other)
    {
        if (Input.GetButton("E"))
        {
            Minigame.SetActive(true);
        }

        else
        {
            Minigame.SetActive(false);
        }

    }
}
