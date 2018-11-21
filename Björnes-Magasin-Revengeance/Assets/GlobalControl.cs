using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalControl : MonoBehaviour {

    public static GlobalControl Instance;

    public GameObject player;
    public GameObject PickUpTable;
    public GameObject OutsideBakerySpawn;
    public GameObject CameraStand;
    public GameObject Canvas;
    public GameObject CanvasDialogue;
    public GameObject eventSystem;
    public GameObject RythmGame;
    public GameObject map;
    public GameObject loadController;
    public GameObject light;
    public GameObject lampPost;


    void Awake() {

        player = GameObject.FindGameObjectWithTag("Player");
        PickUpTable = GameObject.FindGameObjectWithTag("PickUpTable");
        OutsideBakerySpawn = GameObject.FindGameObjectWithTag("OutsideBakerySpawn");
        CameraStand = GameObject.FindGameObjectWithTag("CameraStand");
        Canvas = GameObject.FindGameObjectWithTag("Canvas");
        CanvasDialogue = GameObject.FindGameObjectWithTag("CanvasDialogue");
        eventSystem = GameObject.FindGameObjectWithTag("EventSystem");
        RythmGame = GameObject.FindGameObjectWithTag("RythmGame");
        map = GameObject.FindGameObjectWithTag("Map");
        loadController = GameObject.FindGameObjectWithTag("LoadController");
        light = GameObject.FindGameObjectWithTag("Light");
        lampPost = GameObject.FindGameObjectWithTag("LampPost");






        if (Instance == null) {

            DontDestroyOnLoad(gameObject);
            DontDestroyOnLoad(player);
            DontDestroyOnLoad(PickUpTable);
            DontDestroyOnLoad(OutsideBakerySpawn);
            DontDestroyOnLoad(CameraStand);
            DontDestroyOnLoad(loadController);
            DontDestroyOnLoad(Canvas);
            DontDestroyOnLoad(CanvasDialogue);
            DontDestroyOnLoad(eventSystem);
            DontDestroyOnLoad(RythmGame);
            DontDestroyOnLoad(map);
            DontDestroyOnLoad(light);
            DontDestroyOnLoad(lampPost);
           
         
            Instance = this;





        }
        else if (Instance != this) {


            Destroy(gameObject);
         

            return;


        }




    }
}
