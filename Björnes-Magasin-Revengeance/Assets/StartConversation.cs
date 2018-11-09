using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartConversation : MonoBehaviour {

    public GameObject conversationWith;

    void Start()
    {
        conversationWith.SetActive(false);
    }

    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            conversationWith.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            conversationWith.SetActive(false);
        }
    }
}
