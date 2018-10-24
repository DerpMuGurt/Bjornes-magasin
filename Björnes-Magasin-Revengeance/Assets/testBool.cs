using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testBool : MonoBehaviour {

    public bool cam1;
    public bool cam2;
    public bool cam3;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    public void FirstCam(string FirstCam) {

        cam1 = true;
        cam2 = false;
        cam3 = false;


    }
    public void SecondCam(string SecondCam) {

        cam1 = false;
        cam2 = true;
        cam3 = false;

    }
    public void ThirdCam(string ThirdCam) {

        cam1 = false;
        cam2 = false;
        cam3 = true;

    }

}
