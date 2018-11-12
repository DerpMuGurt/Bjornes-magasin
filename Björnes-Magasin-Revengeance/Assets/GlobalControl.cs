using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalControl : MonoBehaviour {

    public static GlobalControl Instance;

    public GameObject player;
    public GameObject PickUpTable;
    public GameObject OutsideBakerySpawn;
    public GameObject CameraStand;
    

    void Awake() {

        player = GameObject.FindGameObjectWithTag("Player");
        PickUpTable = GameObject.FindGameObjectWithTag("PickUpTable");
        OutsideBakerySpawn = GameObject.FindGameObjectWithTag("OutsideBakerySpawn");
        CameraStand = GameObject.FindGameObjectWithTag("CameraStand");
       
      

      




        if (Instance == null) {

            DontDestroyOnLoad(gameObject);
            DontDestroyOnLoad(player);
            DontDestroyOnLoad(PickUpTable);
            DontDestroyOnLoad(OutsideBakerySpawn);
            DontDestroyOnLoad(CameraStand);
           
         
            Instance = this;





        }
        else if (Instance != this) {


            Destroy(gameObject);
           
            
           


        }




    }
}
