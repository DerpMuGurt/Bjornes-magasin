﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PlayerMovement : MonoBehaviour {

    
    public float walkSpeed;

    public float rotSpeed;
<<<<<<< HEAD
<<<<<<< HEAD
=======
<<<<<<< HEAD


=======
>>>>>>> parent of 3d11d37... Fixed
=======
>>>>>>> fe31564501bbec4cc9fdad72faf5bcf2f6ce7b72

    float angle0 = 0f;
    float angle269 = 269f;
    
<<<<<<< HEAD
>>>>>>> 995f8a4dd2abd9aa06e93688319313ea1c389411
<<<<<<< HEAD

=======
>>>>>>> parent of 3d11d37... Fixed
=======
>>>>>>> fe31564501bbec4cc9fdad72faf5bcf2f6ce7b72

    public float rotateMe;

    public Vector3 offsetCam;

    public int horizontalRotation;

<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
    public GameObject level;
=======
=======
=======
>>>>>>> fe31564501bbec4cc9fdad72faf5bcf2f6ce7b72

    public GameObject level;


 


    public Transform cam;

  

=======
    public GameObject level;
=======
    public Transform cam;
>>>>>>> 995f8a4dd2abd9aa06e93688319313ea1c389411
>>>>>>> parent of 3d11d37... Fixed

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
        EAV1 = new Vector3(0, 20, 0);
        EAV2 = new Vector3(0, -20, 0);

    }


     void LateUpdate() {
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======

>>>>>>> fe31564501bbec4cc9fdad72faf5bcf2f6ce7b72

=======
>>>>>>> parent of 3d11d37... Fixed

        //Camera.main.transform.LookAt(player);
       

    }

    void Update() {
=======

        //Camera.main.transform.LookAt(player);
       

    }
>>>>>>> 995f8a4dd2abd9aa06e93688319313ea1c389411



    void Update() {

<<<<<<< HEAD
<<<<<<< HEAD
       //print(transform.eulerAngles.x);
        print(transform.eulerAngles.y);
       // print(transform.eulerAngles.z);


        //Move and rotate with controller in XAxis using Rigidbody transform.right and Quaternion.Euler to rotate. Horizontal makes it move and rotate to the right.
        if (Input.GetAxis("Horizontal") >= 1f) {

<<<<<<< HEAD
            rb.MovePosition(transform.position + transform.right * Time.deltaTime * walkSpeed);
            Quaternion deltaRotation = Quaternion.Euler(EAV1 * Time.deltaTime);
            rb.MoveRotation(rb.rotation * deltaRotation);
=======
=======
>>>>>>> fe31564501bbec4cc9fdad72faf5bcf2f6ce7b72

=======
<<<<<<< HEAD
>>>>>>> parent of 3d11d37... Fixed
       //print(transform.eulerAngles.x);
        print(transform.eulerAngles.y);
       // print(transform.eulerAngles.z);



        //Move and rotate with controller in XAxis using Rigidbody transform.right and Quaternion.Euler to rotate. Horizontal makes it move and rotate to the right.
        if (Input.GetAxis("Horizontal") >= 1f) {

            rb.MovePosition(transform.position + transform.right * Time.deltaTime * walkSpeed);
            Quaternion deltaRotation = Quaternion.Euler(EAV1 * Time.deltaTime);
            rb.MoveRotation(rb.rotation * deltaRotation);
=======


<<<<<<< HEAD
       //print(transform.eulerAngles.x);
       // print(transform.eulerAngles.y);
       // print(transform.eulerAngles.z);
>>>>>>> 995f8a4dd2abd9aa06e93688319313ea1c389411
<<<<<<< HEAD
=======
>>>>>>> fe31564501bbec4cc9fdad72faf5bcf2f6ce7b72

            Camera.main.transform.position = player.transform.position + offset;
=======
>>>>>>> parent of 3d11d37... Fixed

<<<<<<< HEAD
<<<<<<< HEAD
            // transform.Rotate(0, 2, 0);

        }

        //Move and rotate with controller in XAxis using Rigidbody transform.right and Quaternion.Euler to rotate. Horizontal2 makes it move and rotate to the left. Made it inverted.

<<<<<<< HEAD
=======
            Camera.main.transform.position = player.transform.position + offset;

<<<<<<< HEAD
=======

>>>>>>> fe31564501bbec4cc9fdad72faf5bcf2f6ce7b72
            // transform.Rotate(0, 2, 0);

        }

     

        

  
        if (Input.GetAxis("Horizontal2") >= 1f) {

            rb.MovePosition(transform.position - transform.right * Time.deltaTime * walkSpeed);

            Quaternion deltaRotation = Quaternion.Euler(EAV2 * Time.deltaTime);
            rb.MoveRotation(rb.rotation * deltaRotation);

           

        }


        //Move in ZAxis with keyboard using Rigidbody and transform forward.
        if (Input.GetKey(KeyCode.W)) {

            rb.MovePosition(transform.position + transform.forward * Time.deltaTime * walkSpeed);
           // Camera.main.transform.position = CameraTarget.transform.position;
            
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
=======

>>>>>>> 3d11d37d2fc9ef8e59d5021ea3601958bf74e030
=======
=======
>>>>>>> parent of 3d11d37... Fixed
        //Move and rotate with controller in XAxis using Rigidbody transform.right and Quaternion.Euler to rotate. Horizontal makes it move and rotate to the right.
        if (Input.GetAxis("Horizontal") >= 1f) {
=======

>>>>>>> fe31564501bbec4cc9fdad72faf5bcf2f6ce7b72


        //Move and rotate with controller in XAxis using Rigidbody transform.right and Quaternion.Euler to rotate. Horizontal makes it move and rotate to the right.
    

        //Move and rotate with controller in XAxis using Rigidbody transform.right and Quaternion.Euler to rotate. Horizontal2 makes it move and rotate to the left. Made it inverted.

      


        //Move in ZAxis with keyboard using Rigidbody and transform forward.
        if (Input.GetKey(KeyCode.W)) {

<<<<<<< HEAD

            Vector3 movement = new Vector3(0.0f, 0.0f, 1.0f);
            transform.rotation = Quaternion.LookRotation(movement);


            transform.Translate(movement * walkSpeed * Time.deltaTime, Space.World);

            // rb.MovePosition(transform.position + transform.forward * Time.deltaTime * walkSpeed);
            // Camera.main.transform.position = CameraTarget.transform.position;


        }

        //Move in ZAxis with keyboard using Rigidbody and transform.forward.
        if (Input.GetKey(KeyCode.S)) {


            Vector3 movement = new Vector3(0.0f, 0.0f, -1.0f);
            transform.rotation = Quaternion.LookRotation(movement);


            transform.Translate(movement * walkSpeed * Time.deltaTime, Space.World);
            //rb.MovePosition(transform.position - transform.forward * Time.deltaTime * walkSpeed);

        }

        //Move and rotate in XAxis with keyboard using Rigidbody and transform.right.

        if (Input.GetKey(KeyCode.D)) {

            // transform.Translate(0.15f, 0, 0);

            // transform.Rotate(0, 0.5f, 0);

         //   if (cam.transform.eulerAngles.y >= 90 && cam.transform.eulerAngles.y <= 359.999f) {
            //    Vector3 movement = new Vector3(1.0f, 0.0f, 0.0f);
           //     transform.rotation = Quaternion.LookRotation(movement);
           //     transform.Translate(movement * walkSpeed * Time.deltaTime, Space.World);

          //  }

          //  if (cam.transform.eulerAngles.y >= 359.999f && cam.transform.eulerAngles.y <= 270) {
         //       Vector3 movement = new Vector3(1.0f, 0.0f, 0.0f);
          //      transform.rotation = Quaternion.LookRotation(movement);
        //        transform.Translate(movement * walkSpeed * Time.deltaTime, Space.World);

          //  }


            // rb.MovePosition(transform.position + transform.right * Time.deltaTime * walkSpeed);
            //  Quaternion deltaRotation = Quaternion.Euler(EAV1 * rotSpeed);
            // rb.MoveRotation(rb.rotation * deltaRotation);


            // Camera.main.transform.position = player.transform.position + offset;



        }

     

        //Move and rotate in XAxis with keyboard using Rigidbody and transform.right.
        if (Input.GetKey(KeyCode.A)) {

            //rb.MovePosition(transform.position - transform.right * Time.deltaTime * walkSpeed);

            //transform.Translate(-0.15f, 0,0);
      




            //transform.Rotate(0, -0.5f, 0);



            // Quaternion deltaRotation = Quaternion.Euler(EAV2 * rotSpeed);
            //   rb.MoveRotation(rb.rotation * deltaRotation);

            // Camera.main.transform.position = player.transform.position + offset;

            //transform.eulerAngles = new Vector3(0, -90, 0);
        }







        //Move in in ZAxis with controller.

        // var z = Input.GetAxis("Vertical") * Time.deltaTime * walkSpeed;

        //  transform.Translate(0, 0, z);


>>>>>>> 995f8a4dd2abd9aa06e93688319313ea1c389411
<<<<<<< HEAD
=======
            rb.MovePosition(transform.position + transform.forward * Time.deltaTime * walkSpeed);
           // Camera.main.transform.position = CameraTarget.transform.position;
            
>>>>>>> fe31564501bbec4cc9fdad72faf5bcf2f6ce7b72

        }

        //Move in ZAxis with keyboard using Rigidbody and transform.forward.
        if (Input.GetKey(KeyCode.S)) {

            rb.MovePosition(transform.position - transform.forward * Time.deltaTime * walkSpeed);

        }

        //Move and rotate in XAxis with keyboard using Rigidbody and transform.right.

        if (Input.GetKey(KeyCode.D)) {

            transform.Translate(0, 0, 0.15f);

            // rb.MovePosition(transform.position + transform.right * Time.deltaTime * walkSpeed);
            Quaternion deltaRotation = Quaternion.Euler(EAV1 * rotSpeed);
            rb.MoveRotation(rb.rotation * deltaRotation);

            // Camera.main.transform.position = player.transform.position + offset;

         

        }

        //Move and rotate in XAxis with keyboard using Rigidbody and transform.right.
        if (Input.GetKey(KeyCode.A)) {

            //rb.MovePosition(transform.position - transform.right * Time.deltaTime * walkSpeed);

            transform.Translate(0,0,0.15f);

             Quaternion deltaRotation = Quaternion.Euler(EAV2 * rotSpeed);
              rb.MoveRotation(rb.rotation * deltaRotation);

            // Camera.main.transform.position = player.transform.position + offset;

            //transform.eulerAngles = new Vector3(0, -90, 0);
        }



       

        //Move in in ZAxis with controller.

  

=======
>>>>>>> parent of 3d11d37... Fixed

        }

        //Move in ZAxis with keyboard using Rigidbody and transform.forward.
       

        //Move and rotate in XAxis with keyboard using Rigidbody and transform.right.
    



       

        //Move in in ZAxis with controller.

        var z = Input.GetAxis("Vertical") * Time.deltaTime * walkSpeed;

        transform.Translate(0, 0, z);




        }

        //Move in ZAxis with keyboard using Rigidbody and transform.forward.
      

<<<<<<< HEAD

<<<<<<< HEAD
=======
        //Move and rotate in XAxis with keyboard using Rigidbody and transform.right.
>>>>>>> fe31564501bbec4cc9fdad72faf5bcf2f6ce7b72
       



       





<<<<<<< HEAD

<<<<<<< HEAD
=======
>>>>>>> parent of 3d11d37... Fixed
=======
>>>>>>> 995f8a4dd2abd9aa06e93688319313ea1c389411
=======
>>>>>>> fe31564501bbec4cc9fdad72faf5bcf2f6ce7b72
    }





