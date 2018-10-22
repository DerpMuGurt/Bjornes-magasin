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
    public Animator animator;
    public Animator animatorChoice;
    static public bool doneTalking;
    bool playerIsChoosing;
    bool buttonsWorks;
    bool choice1;
    bool choice2;
    bool choice3;
    bool playerMadeChoice1;
    bool playerMadeChoice2;
    bool playerMadeChoice3;
    bool moreThanOneIsTalking;
    bool iAmAnswering;
    public GameObject whoElseIsTalking;
    public GameObject iAmTalking;
    public GameObject putAnswerForChoice1Here;
    public GameObject putAnswerForChoice2Here;
    public GameObject putAnswerForChoice3Here;

    public GameObject choiceMenu;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && DialogueTrigger.talking == true)
        {
            DisplayNextSentence();
        }
        if (Input.GetKeyDown(KeyCode.E) && choice1 == true)
        {
            DisplayNextChoice1Sentence();

        }

        if (Input.GetKeyDown(KeyCode.E) && choice2 == true)
        {
            DisplayNextChoice2Sentence();
        }

        if (Input.GetKeyDown(KeyCode.E) && choice3 == true)
        {
            DisplayNextChoice3Sentence();
        }

    }
    // Use this for initialization
    void Start() {
        sentences = new Queue<string>();
        choice1Sentences = new Queue<string>();
        choice2Sentences = new Queue<string>();
        choice3Sentences = new Queue<string>();
    }

    public void StartDialogue(Dialogue dialogue)
    {

        // Dialogue
        animator.SetBool("IsOpen", true);
        doneTalking = false;
        nameText.text = dialogue.name;
        playerIsChoosing = dialogue.hasFollowUp;
        moreThanOneIsTalking = dialogue.isTalkingTo;
        iAmAnswering = dialogue.isAnswering;
        iAmTalking = dialogue.myVoice;
        whoElseIsTalking = dialogue.conversationWith;
        playerMadeChoice1 = dialogue.choseChoice1;
        playerMadeChoice2 = dialogue.choseChoice2;
        playerMadeChoice3 = dialogue.choseChoice3;
        putAnswerForChoice1Here = dialogue.choice1Triggers;
        putAnswerForChoice2Here = dialogue.choice2Triggers;
        putAnswerForChoice3Here = dialogue.choice3Triggers;
        sentences.Clear();


        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        // CHOICES
        choiceButtonText1.text = dialogue.choice1;
        choiceButtonText2.text = dialogue.choice2;
        choiceButtonText3.text = dialogue.choice3;

        choice1Sentences.Clear();

        foreach (string sentence in dialogue.choice1Text)
        {
            choice1Sentences.Enqueue(sentence);
        }

        choice2Sentences.Clear();

        foreach (string sentence in dialogue.choice2Text)
        {
            choice2Sentences.Enqueue(sentence);
        }

        choice3Sentences.Clear();

        foreach (string sentence in dialogue.choice3Text)
        {
            choice3Sentences.Enqueue(sentence);
        }
    }

    public void DisplayNextSentence()
    {
        if (sentences.Count == 0 && playerIsChoosing == false && moreThanOneIsTalking == false && iAmAnswering == false)
        {
            EndDialogue();
            return;
        }

        //You can choose to call another at the end of a sentence BUT ONLY at the end of a sentence
        if (sentences.Count == 0 && playerIsChoosing == false && moreThanOneIsTalking == true && iAmAnswering == false)
        {
            MoreThanOneVoice();
            return;
        }
        //The trigger that is answering 
        if (sentences.Count == 0 && playerIsChoosing == false && moreThanOneIsTalking == false && iAmAnswering == true)
        {
            JustOneVoiceNow();
            return;
        }
        //Will the trigger ask a question
        if (sentences.Count == 0 && playerIsChoosing == true)
        {
            StartChoice();
            return;
        }
        string sentence = sentences.Dequeue();
        dialogueText.text = sentence;
    }
    void EndDialogue()
    {
        animator.SetBool("IsOpen", false);
        Debug.Log("End of conversation");
        doneTalking = true;
    }

    void MoreThanOneVoice()
    {
        Debug.Log("Let me talk");
        whoElseIsTalking.SetActive(true);
        iAmTalking.SetActive(false);
        doneTalking = true;
    }

    void JustOneVoiceNow()
    {
        iAmTalking.SetActive(false);
        Debug.Log("IM done");
        animator.SetBool("IsOpen", false);
        doneTalking = true;
    }

    public void StartChoice()
    {
        Debug.Log("Start choice");
        choiceMenu.SetActive(true);
        animator.SetBool("IsOpen", true);

    }

    void ChoiceAnswered1()
    {
        animator.SetBool("IsOpen", false);
        Debug.Log("You made choice 1");
        doneTalking = true;
        playerIsChoosing = false;
        putAnswerForChoice1Here.SetActive(true);
        iAmTalking.SetActive(false);
    }
    void ChoiceAnswered2()
    {
        animator.SetBool("IsOpen", false);
        Debug.Log("End of conversation");
        doneTalking = true;
        playerIsChoosing = false;
        putAnswerForChoice2Here.SetActive(true);
        iAmTalking.SetActive(false);
    }
    void ChoiceAnswered3()
    {
        animator.SetBool("IsOpen", false);
        Debug.Log("End of conversation");
        doneTalking = true;
        playerIsChoosing = false;
        putAnswerForChoice3Here.SetActive(true);
        iAmTalking.SetActive(false);
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
        Debug.Log("Start choice 1");
        if (choice1Sentences.Count == 0 && playerMadeChoice1 == false)
        {
            choice1 = false;
            EndDialogue();
            return;
        }

        if (choice1Sentences.Count == 0 && playerMadeChoice1 == true)
        {
            choice1 = false;
            ChoiceAnswered1();
            return;
        }

        string sentence = choice1Sentences.Dequeue();
        choice1Text.text = sentence;
    }

    public void DisplayNextChoice2Sentence()
    {
        choiceMenu.SetActive(false);
        Debug.Log("Start choice 2");
        if (choice2Sentences.Count == 0 && playerMadeChoice2 == false)
        {
            choice2 = false;
            EndDialogue();
            return;
        }
        if (choice2Sentences.Count == 0 && playerMadeChoice2 == true)
        {
            choice2 = false;
            ChoiceAnswered2();
            return;
        }
        string sentence = choice2Sentences.Dequeue();
        choice2Text.text = sentence;
    }

    public void DisplayNextChoice3Sentence()
    {
        choiceMenu.SetActive(false);
        Debug.Log("Start choice 3");
        if (choice3Sentences.Count == 0 && playerMadeChoice3 == false)
        {
            choice3 = false;
            EndDialogue();
            return;
        }
        if (choice3Sentences.Count == 0 && playerMadeChoice3 == true)
        {
            choice3 = false;
            ChoiceAnswered3();
            return;
        }
        string sentence = choice3Sentences.Dequeue();
        choice3Text.text = sentence;
    }
}
