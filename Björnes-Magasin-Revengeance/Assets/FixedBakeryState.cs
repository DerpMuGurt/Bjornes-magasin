using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixedBakeryState : MonoBehaviour {

    public static FixedBakeryState instance;

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