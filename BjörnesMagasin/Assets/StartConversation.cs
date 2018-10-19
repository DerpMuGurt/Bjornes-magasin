using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartConversation : MonoBehaviour {


    Material m_Material;
    GameObject building;


    // Use this for initialization
    void Start () {


        building = GameObject.FindGameObjectWithTag("Building");
        m_Material = GetComponent<Renderer>().material;

    }
	
	// Update is called once per frame
	void Update () {
		
	}


     void OnTriggerStay(Collider other) {
        
        if(other.gameObject.tag == "NpcTrigger") {

            if (Input.GetKey(KeyCode.E)) {

                building.transform.GetComponent<Renderer>().material.color = Color.red;

            }



        }

    }

}
