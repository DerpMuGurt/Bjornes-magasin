using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempobarScript : MonoBehaviour {

    public int pointsToReach;
    SelectorScript selector;

    void Start()
    {
        selector = GetComponent<SelectorScript>();
    }

    void Update()
    {
        if(selector.points == pointsToReach)
        {
            Destroy(this);
        }
    }

}
