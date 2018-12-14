using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetGameObjectInactive : MonoBehaviour {

    public GameObject thisCon;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerStay(Collider other)
    {
        thisCon.SetActive(false);
    }
        void OnDesable()
    {

    }
}
