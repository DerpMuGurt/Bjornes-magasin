using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public float Cameramovespeed = 120.0f;
    public GameObject CameraFollowObj;
    Vector3 FollowPOS;
    public float clamAngle = 80f;
    public float inputSensitivity = 150.0f;
    public GameObject CameraObj;
    public GameObject PlayerObj;

}
