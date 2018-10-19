using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempobarScript : MonoBehaviour {

    public int pointsToReach = 10;
    SelectorScript selector;

    void Start()
    {
        selector = GetComponent<SelectorScript>();
        this.gameObject.SetActive(false);
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.R))
        { 
            this.gameObject.SetActive(true);
        }
        if(selector.points == pointsToReach)
        {
            this.gameObject.SetActive(false);
        }
    }
}
