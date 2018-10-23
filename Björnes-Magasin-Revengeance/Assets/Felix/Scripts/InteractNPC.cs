using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractNPC : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}



     void OnTriggerStay(Collider other) {

        if(other.gameObject.tag == "NPC" && Input.GetKey("joystick button 0")) {
           

                Debug.Log("StartConversation");

            



        }
        
    }


}
