using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartNew : MonoBehaviour {

    public GameObject thisObject;
    public GameObject newObject;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (DialogueManager.doneTalking == true)
        {
            thisObject.SetActive(false);
            newObject.SetActive(true);
        }
    }
}
