using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class questIsFinnished : MonoBehaviour
{

    GameObject oldHouse;
    GameObject newHouse;

    // Use this for initialization
    void Start()
    {
        oldHouse.SetActive(false);
        newHouse.SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {
        oldHouse = GameObject.FindGameObjectWithTag("BrokenBakery");
        newHouse = GameObject.FindGameObjectWithTag("FixedBakery");
    }
}
