using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bookScript : MonoBehaviour {

    public GameObject textBox;
    public GameObject thisObject;
    public GameObject textAfter;

	// Use this for initialization
	void Start () {

         textBox.SetActive(false);
        //FindObjectOfType<DialogueManager>().EndDialogue();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.E) && DialogueTrigger.talking == true || Input.GetKeyDown("joystick button 0"))
        {
            thisObject.SetActive(false);
            textAfter.SetActive(true);
            textBox.SetActive(true);
        }
    }
}
