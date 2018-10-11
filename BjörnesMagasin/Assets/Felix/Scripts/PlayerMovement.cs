﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PlayerMovement : MonoBehaviour {

    
    public float walkSpeed;

    public float rotationSpeedx;
    public float rotationSpeedy;

    public float rotateMe;

    public Vector3 offsetCam;

    public int horizontalRotation;

    public Transform player;

    Rigidbody rb;
    Vector3 EAV1;
    Vector3 EAV2;

    public Vector3 offset;

    public GameObject CameraTarget;


     void Start() {

        

       // offset = Camera.main.transform.position - player.transform.position;
        CameraTarget = GameObject.FindGameObjectWithTag("CameraTarget");

        //player = GameObject.FindGameObjectWithTag("Player");

        rb = GetComponent<Rigidbody>();

        //Gives values to the vectors that are used in rotations.
        EAV1 = new Vector3(0, 150, 0);
        EAV2 = new Vector3(0, -150, 0);

    }


     void LateUpdate() {

        //Camera.main.transform.LookAt(player);
       

    }

    void Update() {

   


        //Move and rotate with controller in XAxis using Rigidbody transform.right and Quaternion.Euler to rotate. Horizontal makes it move and rotate to the right.
        if (Input.GetAxis("Horizontal") >= 1f) {

            rb.MovePosition(transform.position + transform.right * Time.deltaTime * walkSpeed);
            Quaternion deltaRotation = Quaternion.Euler(EAV1 * Time.deltaTime);
            rb.MoveRotation(rb.rotation * deltaRotation);

            Camera.main.transform.position = player.transform.position + offset;

            // transform.Rotate(0, 2, 0);

        }

        //Move and rotate with controller in XAxis using Rigidbody transform.right and Quaternion.Euler to rotate. Horizontal2 makes it move and rotate to the left. Made it inverted.

        if (Input.GetAxis("Horizontal2") >= 1f) {

            rb.MovePosition(transform.position - transform.right * Time.deltaTime * walkSpeed);

            Quaternion deltaRotation = Quaternion.Euler(EAV2 * Time.deltaTime);
            rb.MoveRotation(rb.rotation * deltaRotation);

            //Camera.main.transform.position = player.transform.position + offset;

            //transform.Rotate(0, -2, 0);

        }


        //Move in ZAxis with keyboard using Rigidbody and transform forward.
        if (Input.GetKey(KeyCode.W)) {

            rb.MovePosition(transform.position + transform.forward * Time.deltaTime * walkSpeed);
           // Camera.main.transform.position = CameraTarget.transform.position;
            

        }

        //Move in ZAxis with keyboard using Rigidbody and transform.forward.
        if (Input.GetKey(KeyCode.S)) {

            rb.MovePosition(transform.position - transform.forward * Time.deltaTime * walkSpeed);

        }

        //Move and rotate in XAxis with keyboard using Rigidbody and transform.right.

        if (Input.GetKey(KeyCode.D)) {

            rb.MovePosition(transform.position + transform.right * Time.deltaTime * walkSpeed);
            Quaternion deltaRotation = Quaternion.Euler(EAV1 * Time.deltaTime);
            rb.MoveRotation(rb.rotation * deltaRotation);

           // Camera.main.transform.position = player.transform.position + offset;

            transform.Rotate(0, 2, 0);

        }

        //Move and rotate in XAxis with keyboard using Rigidbody and transform.right.
        if (Input.GetKey(KeyCode.A)) {

            rb.MovePosition(transform.position - transform.right * Time.deltaTime * walkSpeed);
           
            Quaternion deltaRotation = Quaternion.Euler(EAV2 * Time.deltaTime);
            rb.MoveRotation(rb.rotation * deltaRotation);

           // Camera.main.transform.position = player.transform.position + offset;

            transform.Rotate(0, -2, 0);
        }



       

        //Move in in ZAxis with controller.

        var z = Input.GetAxis("Vertical") * Time.deltaTime * walkSpeed;

        transform.Translate(0, 0, z);






    }



}

