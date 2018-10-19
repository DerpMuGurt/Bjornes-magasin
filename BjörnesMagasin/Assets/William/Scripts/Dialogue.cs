using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Dialogue{

    //NAME
    public string name;
    //DIALOGUE
    [TextArea(1, 20)]
    public string[] sentences;

    //CHOICES
    public bool hasFollowUp;

    public string choice1;
    public string choice2;
    public string choice3;

    [TextArea(1, 20)]
    public string[] choice1Text;
    [TextArea(1, 20)]
    public string[] choice2Text;
    [TextArea(1, 20)]
    public string[] choice3Text;

    public bool choseChoice1;
    public bool choseChoice2;
    public bool choseChoice3;

    [TextArea(1, 20)]
    public string[] choseChoice1Text;

    //TALKING TO OTHERS
    public bool isTalkingTo;
    public bool isAnswering;
    public GameObject choice1Triggers;
    public GameObject choice2Triggers;
    public GameObject choice3Triggers;
    public GameObject myVoice;
    public GameObject conversationWith;
}
