using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollbarScript : MonoBehaviour
{
    SelectorScript selectorScript;

    void Start()
    {
        selectorScript = GetComponent<SelectorScript>();
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Selector")
        {
            if(selectorScript.speed == 0)
            {
                selectorScript.points += 1;
            }
        }
    }
}