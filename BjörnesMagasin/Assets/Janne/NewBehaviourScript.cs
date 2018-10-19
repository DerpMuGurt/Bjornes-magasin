using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Transform player;
    public Transform Helditem;

    bool hasPlayer = false;
    bool BeingCarried = false;

    private bool toutched = false;

    // Update is called once per frame
    void Update()
    {
       float dist = Vector3.Distance(gameObject.transform.position, player.position);
        if (dist <= 2.5f)
        {
           hasPlayer = true;
        }

        else
        {
           hasPlayer = false;
        }

        if(hasPlayer && Input.GetButtonDown("Use"))
        {
            GetComponent<Rigidbody>().isKinematic = true;
            transform.parent = Helditem;
            BeingCarried = true;
        }

        if (Input.GetButtonDown("Drop"))
        {
            GetComponent<Rigidbody>().isKinematic = false;
            transform.parent = null;
            BeingCarried = false;
        }


    }

    void OnTriggerEnter()
    {
        if (BeingCarried)
        {
            toutched = true;
        }
    }
}
