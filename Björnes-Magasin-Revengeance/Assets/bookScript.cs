using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bookScript : MonoBehaviour {

    public GameObject textBefore;
    public GameObject thisObject;
    public GameObject textAfter;

	// Use this for initialization
	void Start () {

           textBefore.SetActive(false);
}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.E) && DialogueTrigger.talking == true || Input.GetKeyDown("joystick button 0"))
        {
            thisObject.SetActive(false);
            textAfter.SetActive(true);
        }
    }
}
