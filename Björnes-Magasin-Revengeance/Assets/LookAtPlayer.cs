using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtPlayer : MonoBehaviour {


    public Transform player;
    public float yourTurnRate = 0.1f;

    // Use this for initialization
    void Start () {


		
	}
	
	// Update is called once per frame
	void Update () {
        player = GameObject.FindWithTag("Player").transform;

        transform.rotation = Quaternion.RotateTowards(
        transform.rotation,
        Quaternion.LookRotation(transform.position - player.position),
        Time.deltaTime * yourTurnRate);
        transform.LookAt(player);

    }
}
