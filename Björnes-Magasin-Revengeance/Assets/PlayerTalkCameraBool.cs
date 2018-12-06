using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTalkCameraBool : MonoBehaviour {

    public bool playerCam;

	// Use this for initialization
	void Start () {
    }
	
	// Update is called once per frame
	void Update () {

        if (playerCam == true)
        {
            FindObjectOfType<talkCamera>().StopLookAt();
            FindObjectOfType<PlayerTalkCamera>().LookAt();
        }
        if (playerCam == false)
        {
            FindObjectOfType<PlayerTalkCamera>().StopLookAt();
        }

        if(DialogueManager.talking == false)
        {
            FindObjectOfType<talkCamera>().StopLookAt();
            playerCam = false;
        }

    }
}
