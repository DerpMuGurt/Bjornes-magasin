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
    public GameObject townHallSpawn;
    public GameObject inSideTownHallSpawn;
    public Transform OutsideBakery;
    public GameObject brokenBakery;
    public GameObject fixedBakery;

   





    // Use this for initialization
    void Start () {

        rb = GetComponent<Rigidbody>();

        OutsideBakerySpawn = GameObject.FindGameObjectWithTag("OutsideBakerySpawn");
        inSideTownHallSpawn = GameObject.FindGameObjectWithTag("InsideTownHallSpawn");

        player = GameObject.FindGameObjectWithTag("Player");
        samePlayer = GameObject.FindWithTag("Player").transform;
  //      OutsideBakery = GameObject.FindWithTag("OutSideBakerySpawn").transform;
  //      townHallSpawn = GameObject.FindGameObjectWithTag("TownHallSpawn");

     

        camStand = GameObject.FindGameObjectWithTag("CameraStand");


    }
	
	// Update is called once per frame
	void Update () {

        brokenBakery = GameObject.FindGameObjectWithTag("BrokenBakery");
        fixedBakery = GameObject.FindGameObjectWithTag("FixedBakery");

        inSideTownHallSpawn = GameObject.FindGameObjectWithTag("InsideTownHallSpawn");
        townHallSpawn = GameObject.FindGameObjectWithTag("TownHallSpawn");

        Scene currentScene = SceneManager.GetActiveScene();

        string sceneName = currentScene.name;




        if (sceneName == "MainMenu") {

            rb.constraints = RigidbodyConstraints.FreezePositionY;


        }


        if (sceneName == "TestDemo") {

            rb.constraints = RigidbodyConstraints.None;
            rb.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ;
            rb.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;


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

        if(other.gameObject.tag == "EnterTownHall") {

            SceneManager.LoadScene("TownHall", LoadSceneMode.Single);
            player.transform.position = inSideTownHallSpawn.transform.position;

        }

        if(other.gameObject.tag == "ExitTownHall") {

            SceneManager.LoadScene("TestDemo", LoadSceneMode.Single);
            player.transform.position = townHallSpawn.transform.position;
            




        }


        
    }


}
