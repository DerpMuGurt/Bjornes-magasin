using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraFollow : MonoBehaviour {

    public float Cameramovespeed = 120.0f;
    public GameObject CameraFollowObj;
    Vector3 FollowPOS;
    public float clampAngle = 80f;
    public float inputSensitivity = 150.0f;
    public GameObject CameraObj;
    public GameObject PlayerObj;
    public float camDistanceXToPlayer;
    public float camDistanceYToPlayer;
    public float camDistanceZToPlayer;
    public float mouseX;
    public float mouseY;
    public float finalInputX;
    public float finalInputZ;
    public float smoothX;
    public float smoothY;
    private float rotY = 0.0f;
    private float rotX = 0.0f;

    
    public float minimumX = -60F;
    public float maximumX = 60F;

    public bool inBakery;
    public bool inWorld;





    void Start() {



        Scene currentScene = SceneManager.GetActiveScene();

        string sceneName = currentScene.name;



       
            Vector3 rot = transform.localRotation.eulerAngles;
            rotY = rot.y;
            rotX = rot.x;
        


        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        inBakery = false;
        inWorld = true;




    }

  


    void Update() {

     

        CameraFollowObj = GameObject.FindGameObjectWithTag("CameraFollow");


        float inputX = Input.GetAxis("Vertical2");
        float inputZ = Input.GetAxis("Horizontal2");
        mouseX = Input.GetAxis("Mouse X");
        mouseY = Input.GetAxis("Mouse Y");

        finalInputX = inputX + mouseX;
        finalInputZ = inputZ - mouseY;


        rotY += finalInputX * inputSensitivity * Time.deltaTime;
        rotX += finalInputZ * inputSensitivity * Time.deltaTime;

        
        rotX = Mathf.Clamp(rotX, minimumX, maximumX);

        rotX = Mathf.Clamp(rotX, -clampAngle, clampAngle);
        Quaternion localRotation = Quaternion.Euler(rotX, rotY, 0.0f);
        transform.rotation = localRotation;

      





    }

    void LateUpdate() {

        CameraUpdater();
    }

    void CameraUpdater() {


        
            Transform target = CameraFollowObj.transform;

            float step = Cameramovespeed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);

       
    }

}
