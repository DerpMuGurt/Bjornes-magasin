using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setActiveWindScene : MonoBehaviour {

    public GameObject CutSceneWin;
    // Use this for initialization


    void OnEnable()
    {
        CutSceneWin.SetActive(true);
    }
    void Start () {

	}

	
	// Update is called once per frame
	void Update () {
		
	}
}
