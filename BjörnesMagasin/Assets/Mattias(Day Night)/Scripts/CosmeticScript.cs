using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CosmeticScript : MonoBehaviour {

    public GameObject sadMask;
    public GameObject hat;
    //equip mask?
    //equipp equipped mask?


	// Use this for initialization
	void Start () {

        sadMask.GetComponentInChildren<Renderer>().enabled = false;
        hat.GetComponentInChildren<Renderer>().enabled = true;

    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("w"))//&& sad mask equipped
        {
            sadMask.GetComponentInChildren<Renderer>().enabled = true;
            hat.GetComponentInChildren<Renderer>().enabled = false;
        }

            if (Input.GetKeyDown("s"))
        {
            sadMask.GetComponentInChildren<Renderer>().enabled = false;
            hat.GetComponentInChildren<Renderer>().enabled = true;
        }

    }
}
