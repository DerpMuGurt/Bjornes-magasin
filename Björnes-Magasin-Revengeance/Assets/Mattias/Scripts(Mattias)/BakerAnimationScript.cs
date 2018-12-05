using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BakerAnimationScript : MonoBehaviour {


    public Animator breadGame;

    private float timer;
    private float successTimer = 2.875f;
    private float failTimer = 3.708f;
    public bool success = false;
    public bool fail = false;

    SelectorScript selecter;

    // Use this for initialization
    void Start () {
        breadGame = GetComponent<Animator>();
        selecter = GetComponent<SelectorScript>();
    }
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        //if (timer >= successTimer)
        //{
        //    breadGame.SetBool("isSuccess", false);
        //}
        //if(timer>= failTimer)
        //{
        //    breadGame.SetBool("isFail", false);
        //}


        if (selecter.hit == true)
        {
            successAnimation();
        }
        if (selecter.hit == false)
        {
            failAnimation();
        }
	}
    void successAnimation()
    {
        breadGame.SetBool("isSuccess", true);
        successTimer = 0;
    }
    void failAnimation()
    {
        breadGame.SetBool("isFail", true);
        failTimer = 0;
    }
}
