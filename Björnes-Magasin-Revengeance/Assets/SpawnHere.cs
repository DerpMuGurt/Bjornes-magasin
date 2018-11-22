using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnHere : MonoBehaviour {

    public GameObject spawnHere;
    public GameObject player;



   void Awake() {

        spawnHere = GameObject.FindGameObjectWithTag("SpawnPoint");
        player = GameObject.FindGameObjectWithTag("Player");

        player.transform.position = spawnHere.transform.position;
    }


    // Use this for initialization
    void Start () {

       


	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
