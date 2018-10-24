using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_Kill_Script : MonoBehaviour
{

    bool active = false;
    GameObject E;

    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            Destroy(E);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        active = true;
        if (collision.gameObject.tag == "E")
            E = collision.gameObject;
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
