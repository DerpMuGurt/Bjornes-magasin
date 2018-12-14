using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setActiveWindScene : MonoBehaviour {

    public GameObject CutSceneWin;

	// Use this for initialization
	void Start () {

	}

    OnEnabled()
    {
        CutSceneWin.SetActive(true);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
