using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarryObject : MonoBehaviour {

    public GameObject PickupPosition;
    public GameObject Egg;
    public GameObject water;

    public GameObject eggTarget;

    float velocity;
    float smoothTime;



    public bool carryThis;
    

    Rigidbody rb;

    // Use this for initialization
    void Start () {

        PickupPosition = GameObject.FindGameObjectWithTag("PickupPosition");
        Egg = GameObject.FindGameObjectWithTag("Egg");
        water = GameObject.FindGameObjectWithTag("Water");

        eggTarget = GameObject.FindGameObjectWithTag("EggTarget");

        carryThis = false;

        rb = GetComponent<Rigidbody>();



    }
	
	// Update is called once per frame
	void Update () {

        if (carryThis == true) {

            pickUp();

        }

        if (carryThis == false) {

            dropOff();

        }




    }


    


     void OnTriggerStay(Collider other) {

        if(other.gameObject.tag == "Egg" || other.gameObject.tag == "Water" ){

            carryThis = true;

       
        } 
        




    }

     void OnTriggerExit(Collider other) {

        if (other.gameObject.tag == "Egg" || other.gameObject.tag == "Water") {

            carryThis = false;

        
        }

    }


    void pickUp() {

        if (Input.GetKeyDown(KeyCode.E) && carryThis == true){
            Egg.transform.position = PickupPosition.transform.position;
            Egg.transform.parent = PickupPosition.transform;

          

        }
    }

    void dropOff() {

        if (Input.GetKeyDown(KeyCode.E) && carryThis == false) {
            Egg.transform.parent = null;
           
            
          

        }
    }

}
