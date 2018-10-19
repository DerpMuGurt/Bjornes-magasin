using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotUsingThis : MonoBehaviour {

    

	// Use this for initialization
	void Start () {

        
		
	}

    // Update is called once per frame
    void Update() {

    }
<<<<<<< HEAD
=======
<<<<<<< HEAD

=======
>>>>>>> parent of 3d11d37... Fixed

     void OnTriggerStay(Collider other) {
        if(other.gameObject.tag == "CircleColliderThing") {
            if (Input.GetKey(KeyCode.E)) {

                Destroy(this);
            }


        }
    }


<<<<<<< HEAD
<<<<<<< HEAD
>>>>>>> 995f8a4dd2abd9aa06e93688319313ea1c389411
=======

>>>>>>> 3d11d37d2fc9ef8e59d5021ea3601958bf74e030
=======
>>>>>>> 995f8a4dd2abd9aa06e93688319313ea1c389411
>>>>>>> parent of 3d11d37... Fixed
}
