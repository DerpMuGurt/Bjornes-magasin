﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
<<<<<<< HEAD

public class CosmeticScript : MonoBehaviour {

    public GameObject sadMask;
    public GameObject hat;
    //equip mask?
    //equipp equipped mask?
=======
using UnityEngine.UI;


public class CosmeticScript : MonoBehaviour {

    public Button cosmeticMask1;
    public Button cosmeticMask2;
    public Button cosmeticMask3;
    public GameObject sadMask;
    public GameObject hat;
>>>>>>> 995f8a4dd2abd9aa06e93688319313ea1c389411



	// Use this for initialization
	void Start () {

        sadMask.GetComponentInChildren<Renderer>().enabled = false;
        hat.GetComponentInChildren<Renderer>().enabled = true;
<<<<<<< HEAD
<<<<<<< HEAD
=======
=======

>>>>>>> 3d11d37d2fc9ef8e59d5021ea3601958bf74e030
        cosmeticMask1.gameObject.SetActive(false);
>>>>>>> 995f8a4dd2abd9aa06e93688319313ea1c389411


    }
	
	// Update is called once per frame
	void Update () {
<<<<<<< HEAD
        if (Input.GetKeyDown("w"))//&& sad mask equipped
        {
            sadMask.GetComponentInChildren<Renderer>().enabled = true;
            hat.GetComponentInChildren<Renderer>().enabled = false;
=======

        if (Input.GetKeyDown("w"))//&& sad mask equipped
        {
            sadMask.GetComponentInChildren<Renderer>().enabled = true;
            hat.GetComponentInChildren<Renderer>().enabled = false;


        if (Input.GetKeyDown("w"))
        {
            cosmeticMask1.gameObject.SetActive(true);
<<<<<<< HEAD
>>>>>>> 995f8a4dd2abd9aa06e93688319313ea1c389411
=======

>>>>>>> 3d11d37d2fc9ef8e59d5021ea3601958bf74e030
        }

            if (Input.GetKeyDown("s"))
        {
<<<<<<< HEAD
<<<<<<< HEAD
=======

>>>>>>> 3d11d37d2fc9ef8e59d5021ea3601958bf74e030
            sadMask.GetComponentInChildren<Renderer>().enabled = false;
            hat.GetComponentInChildren<Renderer>().enabled = true;
        }

<<<<<<< HEAD
=======
=======

>>>>>>> 3d11d37d2fc9ef8e59d5021ea3601958bf74e030
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
<<<<<<< HEAD
>>>>>>> 995f8a4dd2abd9aa06e93688319313ea1c389411
=======

>>>>>>> 3d11d37d2fc9ef8e59d5021ea3601958bf74e030
    }
}
