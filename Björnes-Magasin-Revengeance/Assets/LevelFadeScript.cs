using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelFadeScript : MonoBehaviour {

    public GameObject player;
    public GameObject OutsideBakerySpawn;
    public GameObject townHallSpawn;



    public Animator animator;

    private int levelToLoad;


    // Use this for initialization
    void Start() {

        OutsideBakerySpawn = GameObject.FindGameObjectWithTag("OutsideBakerySpawn");

        player = GameObject.FindGameObjectWithTag("Player");

        townHallSpawn = GameObject.FindGameObjectWithTag("TownHallSpawn");

    }

    // Update is called once per frame
    void Update() {

    }

    public void FadeToLevel(int levelIndex) {

        animator.SetTrigger("FadeOut");


    }

    public void OnFadeComplete() {

        SceneManager.LoadScene(levelToLoad);

    }

    void OnTriggerEnter(Collider player) {

        if (player.gameObject.tag == "EnterBakery") {


            FadeToLevel(1);

        }

        if (player.gameObject.tag == "ExitBakery") {


            FadeToLevel(1);


        }

        if (player.gameObject.tag == "ExitTownHall") {

            FadeToLevel(1);




        }


    }

}
