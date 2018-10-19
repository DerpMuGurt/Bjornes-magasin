using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

  



    void Start() {

       

        Vector3 rot = transform.localRotation.eulerAngles;
        rotY = rot.y;
        rotX = rot.x;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

     


    }


     void Update() {

<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> parent of 3d11d37... Fixed
        float inputX = Input.GetAxis("Horizontal2");
        float inputZ = Input.GetAxis("Vertical2");
       // mouseX = Input.GetAxis("Mouse X");
        //mouseY = Input.GetAxis("Mouse Y");
=======
<<<<<<< HEAD
=======

       

>>>>>>> 3d11d37d2fc9ef8e59d5021ea3601958bf74e030
=======
>>>>>>> parent of 3d11d37... Fixed
        print(transform.eulerAngles.y);

        float inputX = Input.GetAxis("Horizontal2");
        float inputZ = Input.GetAxis("Vertical2");
        mouseX = Input.GetAxis("Mouse X");
        mouseY = Input.GetAxis("Mouse Y");
<<<<<<< HEAD
<<<<<<< HEAD
>>>>>>> 995f8a4dd2abd9aa06e93688319313ea1c389411
=======

>>>>>>> 3d11d37d2fc9ef8e59d5021ea3601958bf74e030
=======
>>>>>>> 995f8a4dd2abd9aa06e93688319313ea1c389411
>>>>>>> parent of 3d11d37... Fixed
        finalInputX = inputX + mouseX;
        finalInputZ = inputZ - mouseY;


        rotY += finalInputX * inputSensitivity * Time.deltaTime;
        rotX += finalInputZ * inputSensitivity * Time.deltaTime;

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
