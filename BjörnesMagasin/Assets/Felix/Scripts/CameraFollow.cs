using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {


    public Transform player;

    public Vector3 offset;

    public float turnSpeed = 4.0f;

    public GameObject CameraTarget;

    public Transform targetPosition;

   public bool camisMobile;
   public bool staticCam;

    
    

    

    // Use this for initialization
    void Start () {

        camisMobile = false;
        staticCam = true;


        CameraTarget = GameObject.FindGameObjectWithTag("CameraTarget");

      offset = transform.position - player.transform.position;

        

       

    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButton(2)) {
            transform.position = CameraTarget.transform.position;
            transform.LookAt(player);
        }


        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.W)) {

            camisMobile = true;
            staticCam = false;
        }
        else {

            camisMobile = false;
            staticCam = true;
        }



    }


     void LateUpdate() {

       // if (camisMobile == true) {
           // transform.position = player.transform.position + offset;
       // }
    }

}
