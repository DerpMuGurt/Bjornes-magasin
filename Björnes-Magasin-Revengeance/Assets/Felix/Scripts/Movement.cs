using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {


    public Transform cam;
    public float walkSpeed;
    Vector2 input;

    public float lookSpeed = 10;
    private Vector3 curLoc;
    private Vector3 prevLoc;

    

    public bool isTurned90;

    // Use this for initialization
    void Start() {


        isTurned90 = false;


    }

    // Update is called once per frame
    void Update() {

        

        input = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        input = Vector2.ClampMagnitude(input, 2);
        



        Vector3 camF = cam.forward;
        Vector3 camR = cam.right;

        camF.y = 0;
        camR.y = 0;

        camF = camF.normalized;
        camR = camR.normalized;

        
       transform.position += (camF * input.y + camR * input.x) * walkSpeed;

       

    

        InputListen();
        

        if (input != Vector2.zero) {
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(transform.localPosition - prevLoc), Time.fixedDeltaTime * lookSpeed);

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