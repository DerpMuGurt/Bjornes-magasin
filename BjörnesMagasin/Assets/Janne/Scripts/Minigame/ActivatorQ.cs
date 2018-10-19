using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivatorQ : MonoBehaviour
{

    bool active = false;
    GameObject NoteQ;

    void Update()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            Destroy(NoteQ);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        active = true;
        if (collision.gameObject.tag == "NoteQ")
            NoteQ = collision.gameObject;
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        active = false;
    }
}
