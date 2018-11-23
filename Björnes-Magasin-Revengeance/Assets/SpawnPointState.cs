using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPointState : MonoBehaviour {

    public static SpawnPointState instance;

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
