using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectorScript : MonoBehaviour {

    public float gameSpeed;
    public int points = 0;
    public float speed;
    public float wallLeft = -80.0f;
    public float wallRight = 80.0f;
    public Vector3 startX;
    float speedDirection = 1.0f;
    private float timer;
    private float waitTimer = 0.5f;
    Vector2 speedAmount;

    void Start()
    {
        speed = gameSpeed;
        points = 0;
        print(speed);
        startX.y = -12;
        startX.z = 79.5f;
    }
    void FixedUpdate()
    {
        timer += Time.deltaTime;
        if (timer >= waitTimer)
        {
            speed = gameSpeed;
        }
    }
    void Update()
    {
        speedAmount.x = speedDirection * speed * Time.deltaTime;
        if (speedDirection > 0.0f && transform.position.x > wallRight)
        {
            speedDirection = -1.0f;
        }
        else if (speedDirection < 0.0f && transform.position.x <= wallLeft)
        {
            speedDirection = 1.0f;
        }
        transform.Translate(speedAmount);
        if (Input.GetKeyDown("space"))
        {
            speed = 0f;
            timer = 0;
            Debug.Log(points);
        }
    }
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "CubeRight")
        {
            print("hello");
            if (Input.GetKeyDown("space"))
            {
                points += 1;
            }
        }
    }
}
