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

        if (player.GetComponent<SceneManagement>().enteredTestDemo == true || player.GetComponent<SceneManagement>().enteredBakery == true) {

            FadeToLevel(1);


        }
             
     }



    public void FadeToLevel(int levelIndex) {

        animator.SetTrigger("FadeOut");


    }

    public void OnFadeComplete() {

        if (player.GetComponent<SceneManagement>().enteredTestDemo == true) {
            SceneManager.LoadScene("TestDemo", LoadSceneMode.Single);

        }
        if (player.GetComponent<SceneManagement>().enteredBakery == true) {
            SceneManager.LoadScene("Bageri", LoadSceneMode.Single);

        }

    }

   


    

}
