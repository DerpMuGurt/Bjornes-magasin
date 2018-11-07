using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMinigameScript : MonoBehaviour {

    public GameObject cubeCollections;
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.E))
        {
            cubeCollections.SetActive(true);
        }
	}
}
