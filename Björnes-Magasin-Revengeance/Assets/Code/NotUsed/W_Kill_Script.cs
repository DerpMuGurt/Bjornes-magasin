using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class W_Kill_Script : MonoBehaviour
{

    bool active = false;
    GameObject W;

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Destroy(W);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        active = true;
        if (collision.gameObject.tag == "W")
            W = collision.gameObject;
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
             GameObject E;
         }
     }
     */
}
