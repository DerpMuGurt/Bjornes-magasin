using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BobDialogue : MonoBehaviour
{

    public GameObject oldDialogue;
    public GameObject newDialogue;

    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
        if (FindObjectsOfType(GetType()).Length > 1)
        {
            Destroy(gameObject);
        }
    }

    void OnEnable()
    {

    }
    // Use this for initialization
    void Update()
    {
        if(questIsFinnished.questIsDone == true)
        {
            oldDialogue.SetActive(false);
            newDialogue.SetActive(true);
        }
        if (questIsFinnished.questIsDone == false)
        {
            oldDialogue.SetActive(true);
            newDialogue.SetActive(false);
        }

    }
}
