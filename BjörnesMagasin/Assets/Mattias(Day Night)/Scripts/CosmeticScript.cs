using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CosmeticScript : MonoBehaviour {

    public Button cosmeticMask1;
    public Button cosmeticMask2;
    public Button cosmeticMask3;
    public GameObject sadMask;
    public GameObject hat;
    
    void Start() {

        sadMask.GetComponentInChildren<Renderer>().enabled = false;
        hat.GetComponentInChildren<Renderer>().enabled = true;
        cosmeticMask1.gameObject.SetActive(false);
  }
	
	void Update () {
        if (Input.GetKeyDown("w"))//&& sad mask equipped
        {
            sadMask.GetComponentInChildren<Renderer>().enabled = true;
            hat.GetComponentInChildren<Renderer>().enabled = false;
   
            if (Input.GetKeyDown("e")) {
                sadMask.GetComponentInChildren<Renderer>().enabled = false;
                hat.GetComponentInChildren<Renderer>().enabled = true;
            }
        }
    }
    void PutOnMask()
    {
        print("click on");
        sadMask.GetComponentInChildren<Renderer>().enabled = true;
        hat.GetComponentInChildren<Renderer>().enabled = false;
    }
}
