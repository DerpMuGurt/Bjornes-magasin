using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour {

    public GameObject player;
    public Transform samePlayer;

    public GameObject camStand;

    Rigidbody rb;

    public GameObject OutsideBakerySpawn;
    public Transform OutsideBakery;

    // Use this for initialization
    void Start () {

        rb = GetComponent<Rigidbody>();

        OutsideBakerySpawn = GameObject.FindGameObjectWithTag("OutsideBakerySpawn");

        player = GameObject.FindGameObjectWithTag("Player");
        samePlayer = GameObject.FindWithTag("Player").transform;
        OutsideBakery = GameObject.FindWithTag("OutSideBakerySpawn").transform;

        camStand = GameObject.FindGameObjectWithTag("CameraStand");


    }
	
	// Update is called once per frame
	void Update () {


        Scene currentScene = SceneManager.GetActiveScene();

        string sceneName = currentScene.name;



        if (sceneName == "MainMenu") {

            rb.constraints = RigidbodyConstraints.FreezePositionY;


        }


        if (sceneName == "TestDemo") {

            rb.constraints = RigidbodyConstraints.None;
            rb.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ;

           

        }

       



}




    


     void OnTriggerEnter(Collider other) {

        if(other.gameObject.tag == "EnterBakery") {

            SceneManager.LoadScene("Bageri", LoadSceneMode.Single);

        }

        if(other.gameObject.tag == "ExitBakery") {

            SceneManager.LoadScene("TestDemo", LoadSceneMode.Single);
            player.transform.position = OutsideBakerySpawn.transform.position;
            samePlayer.transform.LookAt(OutsideBakery);



        }


        
    }


}
