using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class voice : MonoBehaviour
{
    public AudioClip[] voiceClipList;
    public AudioSource voicePitch;

    // Use this for initialization
    void OnEnable()
    {
        DialogueManager.voiceClipListDialogue = voiceClipList;
        DialogueManager.voiceSource = voicePitch;
    }

    // Update is called once per frame
    void Update()
    {
        if (DialogueManager.talking == true)
        {
            voicePitch.mute = false;
        }
        if (DialogueManager.talking == false)
        {
            voicePitch.mute = true;
        }
    }
    void OnDisable()
    {
        voicePitch.mute = false;
    }
}
