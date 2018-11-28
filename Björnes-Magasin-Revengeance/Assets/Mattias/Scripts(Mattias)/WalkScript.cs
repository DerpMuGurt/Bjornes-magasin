using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkScript : MonoBehaviour
{

    public float speed;

    public float xMax = 3;
    public float zMax = 3;
    public float xMin = -3;
    public float zMin = -3;

    private float x;
    private float z;
    private float upSpeed;
    private float angle;

    void Start()
    {
        x = Random.Range(-speed, speed);
        z = Random.Range(-speed, speed);
        angle = Mathf.Atan2(x, z) * (180 / 3.141592f) + 90;
        transform.localRotation = Quaternion.Euler(0, angle, 0);
    }
    void Update()
    {
        upSpeed += Time.deltaTime;
        if (transform.localPosition.x > xMax)
        {
            x = Random.Range(-speed, 0.0f);
            angle = Mathf.Atan2(x, z) * (180 / 3.141592f) + 90;
            transform.localRotation = Quaternion.Euler(0, angle, 0);
            upSpeed = 0.0f;
        }
        if (transform.localPosition.x < xMin)
        {

            x = Random.Range(0.0f, speed);
            angle = Mathf.Atan2(x, z) * (180 / 3.141592f) + 90;
            transform.localRotation = Quaternion.Euler(0, angle, 0);
            upSpeed = 0.0f;
        }
        if (transform.localPosition.z > zMax)
        {
            z = Random.Range(-speed, 0.0f);
            angle = Mathf.Atan2(x, z) * (180 / 3.141592f) + 90;
            transform.localRotation = Quaternion.Euler(0, angle, 0);
            upSpeed = 0.0f;
        }
        if (transform.localPosition.z < zMin)
        {
            z = Random.Range(0.0f, speed);
            angle = Mathf.Atan2(x, z) * (180 / 3.141592f) + 90;
            transform.localRotation = Quaternion.Euler(0, angle, 0);
            upSpeed = 0.0f;
        }
        transform.localPosition = new Vector3(transform.localPosition.x + x, transform.localPosition.y, transform.localPosition.z + z);
    }
}
