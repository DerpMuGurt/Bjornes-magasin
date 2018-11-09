using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour {

    static DontDestroy instans;

    void Start () {
        if (instans)
            Destroy(gameObject);
        //annars behåll karaktären 
        else
        {
            instans = this;
            DontDestroyOnLoad(gameObject);
        }
    }
}
