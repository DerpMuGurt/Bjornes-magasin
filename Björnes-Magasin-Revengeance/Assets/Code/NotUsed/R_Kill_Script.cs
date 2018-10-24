using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class R_Kill_Script : MonoBehaviour
{

    bool active = false;
    GameObject R;

    void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            Destroy(R);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        active = true;
        if (collision.gameObject.tag == "R")
            R = collision.gameObject;
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
