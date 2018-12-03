using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TESTTempoGameStart : MonoBehaviour {

    public GameObject cubeCollections;

    void Update()
    {
        if (Input.GetKey(KeyCode.O))
        {
            cubeCollections.SetActive(true);
        }
    }
}
