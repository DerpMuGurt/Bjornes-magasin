using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class voice : MonoBehaviour
{
    public AudioClip[] voiceClipList;
    public AudioSource voicePitch;

    // Use this for initialization
    void Start()
    {
        DialogueManager.voiceClipListDialogue = voiceClipList;
        DialogueManager.voiceSource = voicePitch;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
