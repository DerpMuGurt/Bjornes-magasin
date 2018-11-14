using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Dialogue{

    //NAME
    public string name;
    public GameObject myVoice;
    public float typingSpeed;
    //DIALOGUE
    [TextArea(1, 20)]
    public string[] sentences;

    //CHOICES
    public bool hasDialogueChoices;

    public bool button1IsActive;
    public bool button2IsActive;
    public bool button3IsActive;

    public string Button1Text;
    public string Button2Text;
    public string Button3Text;

    public bool choice1IsRight;
    public bool choice2IsRight;
    public bool choice3IsRight;

    [TextArea(1, 20)]
    public string[] choice1Sentences;
    [TextArea(1, 20)]
    public string[] choice2Sentences;
    [TextArea(1, 20)]
    public string[] choice3Sentences;

    public bool stopTalkigAfterChoice1;
    public bool stopTalkigAfterChoice2;
    public bool stopTalkigAfterChoice3;
    public GameObject choice1Triggers;
    public GameObject choice2Triggers;
    public GameObject choice3Triggers;


    public bool isHavingAConversation;
    public GameObject isHavingAConversationWith;
}