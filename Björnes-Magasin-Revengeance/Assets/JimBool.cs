using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JimBool : MonoBehaviour {


    public static bool knowJim;
   public GameObject thisCon;
    public GameObject thatCon;
    // Use this for initialization
    void Start () {
		
	}

    void OnEnable()
    {
        knowJim = true;
    }

	// Update is called once per frame
	void Update () {
		
	}

    void OnDisable()
    {
        Destroy(thatCon);
        knowJim = true;
        thisCon.SetActive(true);
    }
}
