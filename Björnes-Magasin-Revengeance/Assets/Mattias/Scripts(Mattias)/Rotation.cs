using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rotation : MonoBehaviour
{

    public float speed = 100.0f;
    Vector3 angle;
    float rotation = 0f;
    public GameObject target;

    public enum Axis
    {
        X,
        Y,
        Z
    }

    public Axis axis = Axis.X;
    public bool direction = true;
    public enum Noon
    {
        DAY,
        NIGHT
    }
    public Noon timeOfDay;

    // Use this for initialization
    void Start()
    {
        angle = transform.localEulerAngles;
        Debug.Log(timeOfDay);
        Debug.Log(RotationX());
        Debug.Log(transform.localEulerAngles.x);
    }

    // Update is called once per frame
    void Update()
    {

        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, 03);
        switch (axis)
        {
            case Axis.X:
                transform.localEulerAngles = new Vector3(RotationX(), angle.y, angle.z);
                break;
            case Axis.Y:
                transform.localEulerAngles = new Vector3(angle.x, RotationX(), angle.z);
                break;
            case Axis.Z:
                transform.localEulerAngles = new Vector3(angle.x, angle.y, RotationX());
                break;
        }

        switch (timeOfDay)
        {
            case Noon.DAY:
                break;
            case Noon.NIGHT:
                break;
        }
        if (transform.eulerAngles.x > 204)
        {
            timeOfDay = Noon.DAY;
        }
        if (transform.eulerAngles.x < 24)
        {
            timeOfDay = Noon.NIGHT;
        }
    }

    float RotationX()
    {
        rotation += speed * Time.deltaTime;
        if (rotation >= 360f)
        {
            rotation -= 360f;
        }
        return direction ? rotation : -rotation;
    }
}