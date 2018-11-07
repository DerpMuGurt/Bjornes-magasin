using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour {

    static DontDestroy instans;

    // Use this for initialization
    void Start () {
        //   DontDestroyOnLoad(gameObject);
  //      DontDestroyOnLoad(this.gameObject);
        if (instans)
            Destroy(gameObject);
        //annars behåll karaktären 
        else
        {
            instans = this;
            DontDestroyOnLoad(gameObject);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
