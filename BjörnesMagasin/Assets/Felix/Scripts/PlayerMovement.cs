using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    
    public float walkSpeed;

    public float rotationSpeed;

    public float rotateMe;

    public int horizontalRotation;

    public GameObject player;

  


     void Start() {

        player = GameObject.FindGameObjectWithTag("Player");
        
    }

     void Update() {

        




        var x = Input.GetAxis("Horizontal") * Time.deltaTime * rotateMe;

        var z = Input.GetAxis("Vertical") * Time.deltaTime * walkSpeed;

        // var y = Input.GetAxis("Horizontal") * Time.deltaTime * rotationSpeed;

        rotationSpeed += Input.GetAxisRaw("Horizontal");
        transform.eulerAngles = new Vector3(0, rotationSpeed, 0);





        //transform.RotateAroundLocal(transform.position, transform.up, horizontalRotation);
        //transform.Rotate(0, y, 0);

        transform.Translate(0, 0, x);

        transform.Translate(0, 0, z);

      //  if (Input.GetKey(KeyCode.A)){

          //  player.transform.Rotate(-Vector3.up * rotationSpeed * Time.deltaTime);

       // }

      //  if (Input.GetKey(KeyCode.D)) {

       //     player.transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);

       // }


        


       
    }



}

