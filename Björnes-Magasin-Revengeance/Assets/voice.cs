using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class voice : MonoBehaviour
{
    public AudioClip[] voiceClipList;

    // Use this for initialization
    void Start()
    {
        DialogueManager.voiceClipListDialogue = voiceClipList;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
