using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActivatorE1 : MonoBehaviour
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
    
   /*
    void OnTriggerStay2D(Collider2D collision)
    {
        active = true;
        if (collision.gameObject.tag == "Press")
        {
            Debug.Log("HitMe");
            if (Input.GetKey(KeyCode.E))
            {
                Destroy(gameObject);
            }
            active = false;
            GameObject NoteE;
        }
    }
    */
}
