using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TownHallCamera : MonoBehaviour {



    public GameObject cam1;
    public GameObject CamPos1;
    public GameObject CamPos2;
    public GameObject CamPos3;

    // Use this for initialization
    void Start() {


        cam1 = GameObject.FindGameObjectWithTag("vcam");
        CamPos1 = GameObject.FindGameObjectWithTag("CamPos1");
        CamPos2 = GameObject.FindGameObjectWithTag("CamPos2");
        CamPos3 = GameObject.FindGameObjectWithTag("CamPos3");


    }

    // Update is called once per frame
    void Update() {



    }


    void OnTriggerStay(Collider other) {
        if (other.gameObject.tag == "CamTriggerOne") {

            cam1.transform.position = CamPos1.transform.position;

        }

        if (other.gameObject.tag == "CamTriggerTwo") {

            cam1.transform.position = CamPos2.transform.position;

        }

        if (other.gameObject.tag == "CamTriggerThree") {

            cam1.transform.position = CamPos3.transform.position;

        }



    }

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "CamTriggerOne") {

            cam1.transform.position = CamPos1.transform.position;

        }

        if (other.gameObject.tag == "CamTriggerTwo") {

            cam1.transform.position = CamPos2.transform.position;

        }

        if (other.gameObject.tag == "CamTriggerThree") {

            cam1.transform.position = CamPos3.transform.position;

        }



    }


}