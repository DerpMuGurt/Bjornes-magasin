﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CosmeticScript : MonoBehaviour {

    public Button cosmeticMask1;
    public Button cosmeticMask2;
    public Button cosmeticMask3;
    public GameObject sadMask;
    public GameObject hat;


	// Use this for initialization
	void Start () {

        sadMask.GetComponentInChildren<Renderer>().enabled = false;
        hat.GetComponentInChildren<Renderer>().enabled = true;
        cosmeticMask1.gameObject.SetActive(false);

    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown("w"))
        {
            cosmeticMask1.gameObject.SetActive(true);
        }

            if (Input.GetKeyDown("s"))
        {
            cosmeticMask1.gameObject.SetActive(false);
        }
        cosmeticMask1.onClick.AddListener(PutOnMask);

        if (Input.GetKeyDown("e"))
        {
            sadMask.GetComponentInChildren<Renderer>().enabled = false;
            hat.GetComponentInChildren<Renderer>().enabled = true;
        }
        
    }
    void PutOnMask()
    {
        print("click on");
        sadMask.GetComponentInChildren<Renderer>().enabled = true;
        hat.GetComponentInChildren<Renderer>().enabled = false;
    }
}
