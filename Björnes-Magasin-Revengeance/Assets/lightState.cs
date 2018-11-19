using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightState : MonoBehaviour {

    public static lightState instance;

    // Use this for initialization


    void Awake() {
        if (instance == null) {
            instance = this;
        }
        else {
            Destroy(this.gameObject);
            return;
        }




    }
}