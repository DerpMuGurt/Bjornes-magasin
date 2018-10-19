using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour {

    public Dialogue dialogue;
    public static bool talking;
  //  public GameObject thisTriggerTriggers;
    void Update()
    {
    //    thisTriggerTriggers = dialogue.myVoice;
        //IF IN COLLISION
        if (Input.GetKeyDown(KeyCode.E) && talking == false)
        {
            FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
            FindObjectOfType<DialogueManager>().DisplayNextSentence();
            talking = true;
        }
        if(DialogueManager.doneTalking == true)
        {
            talking = false;
        }
    }

   // public void TriggerDialogue ()
   // {
     //   FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    //}
}
