using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalControl : MonoBehaviour {

    public static GlobalControl Instance;

    public GameObject player;

    void Awake() {

        player = GameObject.FindGameObjectWithTag("Player");
      

      




        if (Instance == null) {

            DontDestroyOnLoad(gameObject);
            DontDestroyOnLoad(player);
         
            Instance = this;





        }
        else if (Instance != this) {


            Destroy(gameObject);
            Destroy(player);
            
           


        }




    }
}
