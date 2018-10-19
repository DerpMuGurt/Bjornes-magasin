using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestDestroy : MonoBehaviour {

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }


    void OnTriggerEnter2D(Collider2D collision) {




        if (collision.gameObject.tag == "TestPush") {

            if (Input.GetKey(KeyCode.E)) {
                Debug.Log("IsTheButtonE");
            }
        }

    }





    void OnTriggerStay2D(Collider2D collision) {


        if (collision.gameObject.tag == "TestPush") {

            if (Input.GetKey(KeyCode.E)) {
                Debug.Log("IsTheButtonE");
            }
        }

    }

}






