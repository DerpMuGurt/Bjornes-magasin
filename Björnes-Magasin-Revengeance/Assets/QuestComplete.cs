using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestComplete : MonoBehaviour {

    public GameObject fixedBakery;
    public GameObject brokenBakery;




    void Start() {
       
        fixedBakery = GameObject.FindGameObjectWithTag("FixedBakery");
        brokenBakery = GameObject.FindGameObjectWithTag("BrokenBakery");
        fixedBakery.transform.position = brokenBakery.transform.position;
        brokenBakery.SetActive(false);




    }

    void Awake() {

       
        fixedBakery = GameObject.FindGameObjectWithTag("FixedBakery");
        brokenBakery = GameObject.FindGameObjectWithTag("BrokenBakery");
        fixedBakery.transform.position = brokenBakery.transform.position;

        brokenBakery.SetActive(false);


    }


    // Use this for initialization
    void Update () {
       
        fixedBakery = GameObject.FindGameObjectWithTag("FixedBakery");
        brokenBakery = GameObject.FindGameObjectWithTag("BrokenBakery");
        fixedBakery.transform.position = brokenBakery.transform.position;
        brokenBakery.SetActive(false);




    }

   

    // Update is called once per frame
   
}
