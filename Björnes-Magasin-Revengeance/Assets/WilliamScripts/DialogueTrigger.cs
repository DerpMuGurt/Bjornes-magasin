using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour {

    public Dialogue dialogue;
    public static bool talking;
    public static bool isAsking;

void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player" && talking == false && isAsking == false)
        {
                FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
                talking = true;
        }
        if (talking == true && isAsking == true)
        {
            isAsking = false;
            DialogueManager.hasMoreToAsk = false;
            FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
            FindObjectOfType<DialogueManager>().DisplayNextSentence();
            talking = true;
        }

        if (DialogueManager.doneTalking == true)
        {
            talking = false;
        }

        if (DialogueManager.hasMoreToAsk == true)
        {
            isAsking = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            FindObjectOfType<DialogueManager>().EndDialogue();
            talking = false;
        }
    }
    }
