﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartConversation : MonoBehaviour {

    public GameObject conversationWith;
    Transform target;
    bool isLooking;
    public GameObject guiObject;

    void Start()
    {
        conversationWith.SetActive(false);
        isLooking = false;
    }

    private void Update()
    {
        target = GameObject.FindWithTag("Player").transform;
        if (isLooking == true)
        {
            //  transform.LookAt(target, transform.up);
             Vector3 targetPosition = new Vector3(target.transform.position.x, transform.position.y, target.transform.position.z);
             transform.LookAt(targetPosition);
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            guiObject.SetActive(true);
            conversationWith.SetActive(true);
            isLooking = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            guiObject.SetActive(false);
            conversationWith.SetActive(false);
            isLooking = false;
            DialogueTrigger.talking = false;
            transform.rotation = Quaternion.identity;
        }
    }
}