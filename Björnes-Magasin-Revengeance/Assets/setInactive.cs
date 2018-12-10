using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setInactive : MonoBehaviour {

    GameObject buttonImage;

    // Use this for initialization
    void Start () {

    }

    // Update is called once per frame
    void Update () {
		
	}

    private void OnDisable()
    {
        buttonImage = GameObject.FindWithTag("ButtonImage");
        buttonImage.SetActive(false);
    }
}
