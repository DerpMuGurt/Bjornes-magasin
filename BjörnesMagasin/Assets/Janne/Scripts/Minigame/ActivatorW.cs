using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivatorW : MonoBehaviour
{

    bool active = false;
    GameObject NoteW;

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Destroy(NoteW);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        active = true;
        if (collision.gameObject.tag == "NoteW")
            NoteW = collision.gameObject;
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        active = false;
    }
}
