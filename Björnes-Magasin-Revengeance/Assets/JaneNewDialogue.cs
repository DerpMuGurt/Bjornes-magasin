using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JaneNewDialogue : MonoBehaviour {

    public GameObject JaneNewText;
    public GameObject JaneOldText;

    // Use this for initialization
    void Start () {
		
	}
	
    void OnEnable()
    {

            JaneNewText.SetActive(true);
            JaneOldText.SetActive(false);
    }

	// Update is called once per frame
	void Update () {
		
	}
}
