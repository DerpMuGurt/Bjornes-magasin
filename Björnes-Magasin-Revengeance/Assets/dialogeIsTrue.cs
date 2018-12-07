using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialogeIsTrue : MonoBehaviour {

	// Use this for initialization
	void Start () {

        DialogueManager.talking = true;
        FindObjectOfType<talkCamera>().LookAt();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
