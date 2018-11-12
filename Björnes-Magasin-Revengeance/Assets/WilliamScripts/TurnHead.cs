using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnHead : MonoBehaviour
{

    public GameObject turnThis;
    Transform target;
    bool isLooking;

    void Start()
    {
        isLooking = false;
    }

    private void Update()
    {
        target = GameObject.FindWithTag("Player").transform;
        if (isLooking == true)
        {
            Vector3 targetPosition = new Vector3(target.transform.position.x, transform.position.y, target.transform.position.z);
            turnThis.transform.LookAt(targetPosition);
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            isLooking = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            isLooking = false;
            turnThis.transform.rotation = Quaternion.identity;

        }
    }
}
