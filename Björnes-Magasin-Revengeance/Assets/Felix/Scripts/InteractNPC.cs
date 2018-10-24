using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InteractNPC : MonoBehaviour {

    GameObject player;

	// Use this for initialization
	void Start () {

        player = GameObject.FindGameObjectWithTag("Player");
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}



     void OnTriggerStay(Collider other) {

        if(other.gameObject.tag == "NPC" && Input.GetKey("joystick button 0") ||  other.gameObject.tag == "NPC" && Input.GetKey(KeyCode.E)) {

            player.GetComponent<Movement>().enabled = false;

            //SceneManager.LoadScene("TestScene101");





        }
        
    }


}
