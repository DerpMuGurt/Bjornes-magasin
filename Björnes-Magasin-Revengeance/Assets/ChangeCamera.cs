using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCamera : MonoBehaviour {

public Animator cameraController;


void Start () {
	
	
}
	

void OnTriggerEnter (Collider other){
	
	if(other.gameObject.tag == "BottomTrigger"){

            cameraController.SetBool("Cam1", true);
            cameraController.SetBool("Cam2", false);
            cameraController.SetBool("Cam3", false);

        }
	
		if(other.gameObject.tag == "MiddleTrigger"){

            cameraController.SetBool("Cam1", false);
            cameraController.SetBool("Cam2", true);
            cameraController.SetBool("Cam3", false);

        }
	
		if(other.gameObject.tag == "TopTrigger"){

            cameraController.SetBool("Cam1", false);
            cameraController.SetBool("Cam2", false);
            cameraController.SetBool("Cam3", true);

        }
	
	
}
	
	
	
}
