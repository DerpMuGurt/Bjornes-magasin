using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GAMESTART : MonoBehaviour
{
    public GameObject Canvas;

    void Start()
    {
        Canvas.SetActive(false); 
    }

    void OnTriggerEnter(Collider other)
    {
        if (Input.GetButton("E"))
        {
            Canvas.SetActive(true);
        }

        else
        {
            Canvas.SetActive(false);
        }

    }
}
