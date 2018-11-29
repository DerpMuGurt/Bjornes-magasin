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
    public float goTimer = 0f;
    public float stopTimer = 0f;
    public float duration = 5f;

    private float x;
    private float z;
    private float upSpeed;
    private float angle;
    private float wait;

    bool stop = true;

    void Start()
    {
        x = Random.Range(-speed, speed);
        z = Random.Range(-speed, speed);
        angle = Mathf.Atan2(x, z) * (180 / 3.141592f) + 90;
        transform.localRotation = Quaternion.Euler(0, angle, 0);
    }
    void Update()
    {
        if(goTimer < duration && stop)
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
                goTimer = Time.deltaTime;
            }
            else
            {
                stop = false;
                wait = Random.Range(5, 10);
                stopTimer = 0f;
            }
            if(stopTimer < wait && !stop)
            {
                stopTimer += Time.deltaTime;
            }
            else if(!stop)
            {
                goTimer = 0f;
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
            }
        }
        transform.localPosition = new Vector3(transform.localPosition.x + x, transform.localPosition.y, transform.localPosition.z + z);
    }
}
