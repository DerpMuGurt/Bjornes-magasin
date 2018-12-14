using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MayorTotorial : MonoBehaviour {

    public Dialogue dialogue;
    public static bool talking;
    public AudioSource stuff;
    public GameObject thisObject;

    // Use this for initialization


    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player" && dialogue.startDirect == true && talking == false)
        {
            stuff.enabled = false;
            FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
            FindObjectOfType<DialogueManager>().DisplayNextSentence();
            DialogueTrigger.talking = true;
            talking = true;
        }
        if (DialogueManager.doneTalking == true)
        {
            thisObject.SetActive(false);
            stuff.enabled = true;
            talking = false;
        }
    }
}
