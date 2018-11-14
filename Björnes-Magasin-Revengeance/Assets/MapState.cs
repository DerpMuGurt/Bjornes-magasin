using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapState : MonoBehaviour {

    public static MapState instance;

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
