﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Movement : MonoBehaviour {


    public Transform cam;
    public float walkSpeed;
    Vector2 input;
    Vector3 input2;

    public GameObject CameraStand;

    public float lookSpeed = 10;
    private Vector3 curLoc;
    private Vector3 prevLoc;

    Rigidbody rb;
    GameObject player;

    float lockPos = 0f;

    public bool bakeryLevel;
    public bool worldLevel;

    public bool isWalking;
    float epsilon = 1f;

    

    public bool isTurned90;

    // Use this for initialization
    void Start() {

        rb = GetComponent<Rigidbody>();
        player = GameObject.FindGameObjectWithTag("Player");
        

        isTurned90 = false;

        CameraStand = GameObject.FindGameObjectWithTag("CameraStand");

        bakeryLevel = false;
        worldLevel = true;
        isWalking = false;
       

    }



   

    // Update is called once per frame
    void Update() {

        

        Scene currentScene = SceneManager.GetActiveScene();

        string sceneName = currentScene.name;

        

        if (sceneName == "Bageri") {
            bakeryLevel = true;
            worldLevel = false;
            cam = GameObject.FindWithTag("MainCamera").transform;
            //CameraStand.SetActive(false);
        }

        if (sceneName == "TestDemo") {
            worldLevel = true;
            bakeryLevel = false;
            cam = GameObject.FindWithTag("MainCamera").transform;
           // CameraStand.SetActive(true);
            
            
            
        }


        



        input = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        input = Vector2.ClampMagnitude(input, 5);
       

        input2 = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        input2 = Vector3.ClampMagnitude(input, 5);
        input2 = Vector3.zero;



        Vector3 camF = cam.forward;
        Vector3 camR = cam.right;

        camF.y = 0;
        camR.y = 0;

        camF = camF.normalized;
        camR = camR.normalized;

        
       transform.position += (camF * input.y + camR * input.x) * walkSpeed;

        //transform.rotation = Quaternion.Euler(lockPos, transform.rotation.eulerAngles.y, lockPos);



        InputListen();

        

        if (input != Vector2.zero || input2 != Vector3.zero) {


            
             transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(transform.position - prevLoc), Time.deltaTime * lookSpeed);

        }
    
       



    }

    void LookTargetMovementDirection(Vector3 targetPosition, Vector3 targetVelocity) {
        Vector3 targetLookRotation = (targetPosition + targetVelocity) - targetPosition;
        if (targetLookRotation != Vector3.zero) {
            transform.rotation = Quaternion.LookRotation(targetLookRotation);
        }
        else {
            Debug.Log("targetPosition = " + targetPosition);
            Debug.Log("targetVelocity = " + targetVelocity);
            Debug.Log("targetLookRotation = " + targetLookRotation);
        }
    }

    private void InputListen() {


        


            prevLoc = curLoc;
            curLoc = transform.position;



        //  if (Input.GetKey(KeyCode.A))
        //     curLoc.x -= 1 * Time.fixedDeltaTime;
        //   if (Input.GetKey(KeyCode.D))
        //  curLoc.x += 1 * Time.fixedDeltaTime;
        // if (Input.GetKey(KeyCode.W))
        //  curLoc.z += 1 * Time.fixedDeltaTime;
        // if (Input.GetKey(KeyCode.S))
        // curLoc.z -= 1 * Time.fixedDeltaTime;


        transform.position = curLoc;
        
    }


}