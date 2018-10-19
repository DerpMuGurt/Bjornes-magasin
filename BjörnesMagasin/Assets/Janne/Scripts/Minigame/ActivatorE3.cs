using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivatorE3 : MonoBehaviour
{

    bool active = false;
    GameObject NoteE;

    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {

            Destroy(NoteE);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        active = true;
        if (collision.gameObject.tag == "NoteE")
            NoteE = collision.gameObject;
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        active = false;
    }
}
