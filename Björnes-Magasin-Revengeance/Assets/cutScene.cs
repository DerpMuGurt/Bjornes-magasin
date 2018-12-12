using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cutScene : MonoBehaviour
{

    public GameObject Cam1;
    bool hasPlayed;


    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
        if (FindObjectsOfType(GetType()).Length > 1)
        {
            Destroy(gameObject);
        }
    }
    // Use this for initialization
    void Start()
    {
        
        if(hasPlayed == false)
        {
            StartCoroutine(TheSequence());
        }
    }

    void Update()
    {
    }

    IEnumerator TheSequence()
    {
        FindObjectOfType<Movement>().enabled = false;
        Cam1.SetActive(true);
        yield return new WaitForSeconds(4);
        Cam1.SetActive(false);
        FindObjectOfType<Movement>().enabled = true;
        hasPlayed = true;
    }
}
