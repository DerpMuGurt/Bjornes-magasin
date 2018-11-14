using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BakerySpawn : MonoBehaviour {

    public GameObject player;
    public GameObject bakerySpawn;
    public Transform LookAtThis;
    public Transform samePlayer;

    // Use this for initialization
    void Start () {

        player = GameObject.FindGameObjectWithTag("Player");
        bakerySpawn = GameObject.FindGameObjectWithTag("BakerySpawnPoint");

        player.transform.position = bakerySpawn.transform.position;
        LookAtThis = GameObject.FindWithTag("LookAtThis").transform;
        samePlayer = GameObject.FindWithTag("Player").transform;
        samePlayer.transform.LookAt(LookAtThis);

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
