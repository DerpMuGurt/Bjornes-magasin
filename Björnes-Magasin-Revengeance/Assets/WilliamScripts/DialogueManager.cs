using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour {

    public Text nameText;
    public Text dialogueText;
    public Text choice1Text;
    public Text choice2Text;
    public Text choice3Text;
    public Text choiceButtonText1;
    public Text choiceButtonText2;
    public Text choiceButtonText3;
    private Queue<string> sentences;
    private Queue<string> choice1Sentences;
    private Queue<string> choice2Sentences;
    private Queue<string> choice3Sentences;

    public static bool doneTalking;
    public static bool hasMoreToAsk;
    bool playerHasFollowUp;
    bool choice1;
    bool choice2;
    bool choice3;
    bool playerMadeChoice1;
    bool playerMadeChoice2;
    bool playerMadeChoice3;
    bool stopTalingAfter1;
    bool stopTalingAfter2;
    bool stopTalingAfter3;
    bool button1;
    bool button2;
    bool button3;
    bool isTalkingWith;

    float typingSpeed;

    public GameObject iAmTalking;
    public GameObject isTalkingTo;
    public GameObject putAnswerForChoice1Here;
    public GameObject putAnswerForChoice2Here;
    public GameObject putAnswerForChoice3Here;
    public GameObject choiceMenu;
    public GameObject dialogueMenu;
    public GameObject Button1Object;
    public GameObject Button2Object;
    public GameObject Button3Object;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && DialogueTrigger.talking == true || Input.GetKeyDown("joystick button 0") && DialogueTrigger.talking == true)
        {
            DisplayNextSentence();
        }
        if (Input.GetKeyDown(KeyCode.E) && choice1 == true || Input.GetKeyDown("joystick button 0") && choice1 == true)
        {
            DisplayNextChoice1Sentence();
        }

        if (Input.GetKeyDown(KeyCode.E) && choice2 == true || Input.GetKeyDown("joystick button 0") && choice2 == true)
        {
            DisplayNextChoice2Sentence();
        }

        if (Input.GetKeyDown(KeyCode.E) && choice3 == true || Input.GetKeyDown("joystick button 0") && choice3 == true)
        {
            DisplayNextChoice3Sentence();
        }
    }

    void Start() {
        sentences = new Queue<string>();
        choice1Sentences = new Queue<string>();
        choice2Sentences = new Queue<string>();
        choice3Sentences = new Queue<string>();
    }

    public void StartDialogue(Dialogue dialogue)
    {
        doneTalking = false;
        nameText.text = dialogue.name;
        playerHasFollowUp = dialogue.hasDialogueChoices;
        iAmTalking = dialogue.myVoice;
        isTalkingWith = dialogue.isHavingAConversation;
        isTalkingTo = dialogue.isHavingAConversationWith;
        playerMadeChoice1 = dialogue.choice1IsRight;
        playerMadeChoice2 = dialogue.choice2IsRight;
        playerMadeChoice3 = dialogue.choice3IsRight;
        choiceButtonText1.text = dialogue.Button1Text;
        choiceButtonText2.text = dialogue.Button2Text;
        choiceButtonText3.text = dialogue.Button3Text;
        putAnswerForChoice1Here = dialogue.choice1Triggers;
        putAnswerForChoice2Here = dialogue.choice2Triggers;
        putAnswerForChoice3Here = dialogue.choice3Triggers;
        button1 = dialogue.button1IsActive;
        button2 = dialogue.button2IsActive;
        button3 = dialogue.button3IsActive;
        stopTalingAfter1 = dialogue.stopTalkigAfterChoice1;
        stopTalingAfter2 = dialogue.stopTalkigAfterChoice2;
        stopTalingAfter3 = dialogue.stopTalkigAfterChoice3;
        typingSpeed = dialogue.typingSpeed;


        if (iAmTalking.tag == "Player")
        {
            nameText.text = "Player";
        }

        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        choice1Sentences.Clear();

        foreach (string sentence in dialogue.choice1Sentences)
        {
            choice1Sentences.Enqueue(sentence);
        }

        choice2Sentences.Clear();

        foreach (string sentence in dialogue.choice2Sentences)
        {
            choice2Sentences.Enqueue(sentence);
        }

        choice3Sentences.Clear();

        foreach (string sentence in dialogue.choice3Sentences)
        {
            choice3Sentences.Enqueue(sentence);
        }
    }

    public void DisplayNextSentence()
    {
        FindObjectOfType<Movement>().enabled = false;
        dialogueMenu.SetActive(true);
        if (sentences.Count == 0 && playerHasFollowUp == false && isTalkingWith == false)
        {
            EndDialogue();
            return;
        }

        if (sentences.Count == 0 && playerHasFollowUp == true && isTalkingWith == false)
        {
            StartChoice();
            return;
        }
        if (sentences.Count == 0 && isTalkingWith == true)
        {
            StartConversation();
            return;
        }

        string sentence = sentences.Dequeue();
        //  dialogueText.text = sentence;
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }

    IEnumerator TypeSentence (string sentence)
    {
        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }

    public void EndDialogue()
    {
        FindObjectOfType<Movement>().enabled = true;
        doneTalking = true;
        dialogueMenu.SetActive(false);
        choice1 = false;
        choice2 = false;
        choice3 = false;
    }

    public void StartChoice()
    {
        choiceMenu.SetActive(true);
        if (button1 == true)
        {
            Button1Object.SetActive(true);
        }
        else
            Button1Object.SetActive(false);
        if (button2 == true)
        {
            Button2Object.SetActive(true);
        }
        else
            Button2Object.SetActive(false);

        if (button3 == true)
        {
            Button3Object.SetActive(true);
        }
        else
            Button3Object.SetActive(false);

    }

    void StartConversation()
    {
        iAmTalking.SetActive(false);
        //   isTalkingWith
        hasMoreToAsk = true;
        isTalkingTo.SetActive(true);
    }

    void ChoiceAnswered1()
    {
        if (stopTalingAfter1 == false)
        {


            choice1 = false;
            hasMoreToAsk = true;
            playerHasFollowUp = false;
            iAmTalking.SetActive(false);
            putAnswerForChoice1Here.SetActive(true);
        }
         if(stopTalingAfter1 == true)
        {
            playerHasFollowUp = false;
            iAmTalking.SetActive(false);
            putAnswerForChoice1Here.SetActive(true);
            EndDialogue();
        }
    }
    void ChoiceAnswered2()
    {
        if (stopTalingAfter2 == false)
        {
            choice2 = false;
            hasMoreToAsk = true;
            playerHasFollowUp = false;
            iAmTalking.SetActive(false);
            putAnswerForChoice2Here.SetActive(true);
        }
        if (stopTalingAfter2 == true)
        {
            playerHasFollowUp = false;
            iAmTalking.SetActive(false);
            putAnswerForChoice2Here.SetActive(true);
            EndDialogue();
        }
    }
    void ChoiceAnswered3()
    {
        if (stopTalingAfter3 == false)
        {
            choice3 = false;
            hasMoreToAsk = true;
            playerHasFollowUp = false;
            iAmTalking.SetActive(false);
            putAnswerForChoice3Here.SetActive(true);
        }
        if (stopTalingAfter3 == true)
        {
            playerHasFollowUp = false;
            iAmTalking.SetActive(false);
            putAnswerForChoice3Here.SetActive(true);
            EndDialogue();
        }
    }

    public void Choice1()
    {
        choice1 = true;
    }

    public void Choice2()
    {
        choice2 = true;
    }

    public void Choice3()
    {
        choice3 = true;
    }

    public void DisplayNextChoice1Sentence()
    {
        choiceMenu.SetActive(false);
        if (choice1Sentences.Count == 0 && playerMadeChoice1 == false)
        {
            EndDialogue();
            return;
        }

        if (choice1Sentences.Count == 0 && playerMadeChoice1 == true)
        {
            ChoiceAnswered1();
            return;
        }
        string sentence = choice1Sentences.Dequeue();
        //choice1Text.text = sentence;
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }

    public void DisplayNextChoice2Sentence()
    {
        choiceMenu.SetActive(false);
        if (choice2Sentences.Count == 0 && playerMadeChoice2 == false)
        {
            EndDialogue();
            return;
        }
        if (choice2Sentences.Count == 0 && playerMadeChoice2 == true)
        {
            ChoiceAnswered2();
            return;
        }
        string sentence = choice2Sentences.Dequeue();
        // choice2Text.text = sentence;
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }

    public void DisplayNextChoice3Sentence()
    {
        choiceMenu.SetActive(false);
        if (choice3Sentences.Count == 0 && playerMadeChoice3 == false)
        {
            EndDialogue();
            return;
        }
        if (choice3Sentences.Count == 0 && playerMadeChoice3 == true)
        {
            ChoiceAnswered3();
            return;
        }
        string sentence = choice3Sentences.Dequeue();
        // choice3Text.text = sentence;
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }
}