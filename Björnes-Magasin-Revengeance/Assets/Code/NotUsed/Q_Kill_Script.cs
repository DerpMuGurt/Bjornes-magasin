using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Q_Kill_Script : MonoBehaviour
{

    bool active = false;
    GameObject Q;

    void Update()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            Destroy(Q);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        active = true;
        if (collision.gameObject.tag == "Q")
            Q = collision.gameObject;
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
