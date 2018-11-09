using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BakerySpawn : MonoBehaviour {

    public GameObject player;
    public GameObject bakerySpawn;

	// Use this for initialization
	void Start () {

        player = GameObject.FindGameObjectWithTag("Player");
        bakerySpawn = GameObject.FindGameObjectWithTag("BakerySpawnPoint");

        player.transform.position = bakerySpawn.transform.position;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
