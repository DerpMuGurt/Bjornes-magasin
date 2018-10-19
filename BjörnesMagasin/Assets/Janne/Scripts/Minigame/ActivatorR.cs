using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivatorR : MonoBehaviour
{

    bool active = false;
    GameObject NoteR;

    void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            Destroy(NoteR);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        active = true;
        if (collision.gameObject.tag == "NoteR")
            NoteR = collision.gameObject;
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        active = false;
    }
}
