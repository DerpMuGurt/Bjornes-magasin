using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cutScene : MonoBehaviour
{

    public GameObject Cam1;

    // Use this for initialization
    void Start()
    {
        StartCoroutine(TheSequence());
    }

    void Update()
    {
        Time.timeScale = 1f;
    }

    IEnumerator TheSequence()
    {
        Cam1.SetActive(true);
        yield return new WaitForSeconds(6);
        Cam1.SetActive(false);
    }
}
