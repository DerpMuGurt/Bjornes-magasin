using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour {

    public GameObject player;

    public GameObject OutsideBakerySpawn;

	// Use this for initialization
	void Start () {

        OutsideBakerySpawn = GameObject.FindGameObjectWithTag("OutsideBakerySpawn");

        player = GameObject.FindGameObjectWithTag("Player");


    }
	
	// Update is called once per frame
	void Update () {
		
	}


     void OnTriggerEnter(Collider other) {

        if(other.gameObject.tag == "EnterBakery") {

            SceneManager.LoadScene("Bageri", LoadSceneMode.Single);

        }

        if(other.gameObject.tag == "ExitBakery") {

            SceneManager.LoadScene("TestDemo", LoadSceneMode.Single);
            player.transform.position = OutsideBakerySpawn.transform.position;

        }


        
    }


}
