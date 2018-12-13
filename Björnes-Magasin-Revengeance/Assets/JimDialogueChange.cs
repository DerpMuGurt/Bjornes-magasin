using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JimDialogueChange : MonoBehaviour {
    public GameObject oldDialogue;
    public GameObject newDialogue;
    // Use this for initialization
    void Start () {

	}
	
    void OnEnable()
    {
        if (JimBool.knowJim = true)
        {
            oldDialogue.SetActive(false);
            newDialogue.SetActive(true);
}
    }

	// Update is called once per frame
	void Update () {

    }
}
