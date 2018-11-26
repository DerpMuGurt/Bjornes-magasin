using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnHere : MonoBehaviour {

    public GameObject spawnHere;
    public GameObject player;


    private void Awake() {

        Destroy(this.gameObject);
  
        
    }



    // Use this for initialization
    void Start () {

        spawnHere = GameObject.FindGameObjectWithTag("SpawnPoint");
        player = GameObject.FindGameObjectWithTag("Player");

        player.transform.position = spawnHere.transform.position;

        spawnHere.SetActive(false);
        spawnHere.GetComponent<SpawnHere>().enabled = false;




    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
