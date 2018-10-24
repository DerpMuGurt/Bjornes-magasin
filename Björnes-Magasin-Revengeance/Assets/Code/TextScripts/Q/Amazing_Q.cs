﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Amazing_Q: MonoBehaviour
{
    public Text Amazing_Text;

    bool active = false;
    GameObject Q;

    void Start()
    {
        Amazing_Text.text = "Amazing!";
        Amazing_Text.enabled = false;

    }

    void OnTriggerStay2D(Collider2D collision)
    {
        active = true;
        if (collision.gameObject.tag == "Amazing")
        {
            if (Input.GetKey(KeyCode.Q))
            {
                Amazing_Text.enabled = true;
                Destroy(gameObject);
            }
            StartCoroutine(MyTime());
            active = false;
            GameObject Q;
        }
    }

    IEnumerator MyTime()
    {
        yield return new WaitForSeconds(1);
        Amazing_Text.enabled = false;
    }
}
