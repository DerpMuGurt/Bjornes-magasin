using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtPlayer : MonoBehaviour {


    public Transform player;

    // Use this for initialization
    void Start () {


		
	}
	
	// Update is called once per frame
	void Update () {
        player = GameObject.FindWithTag("Player").transform;

        transform.LookAt(player);

    }
}
