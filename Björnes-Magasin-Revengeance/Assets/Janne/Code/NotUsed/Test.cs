using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    bool active = false;
    GameObject E;

     void OnTriggerStay2D(Collider2D collision)
     {
         active = true;
         if (collision.gameObject.tag == "Press")
         {
             Debug.Log("RED WAS HIT");
             if (Input.GetKey(KeyCode.E))
             {
                 Destroy(gameObject);
             }
             active = false;
             GameObject E;
         }
     }
}
