using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectorScript : MonoBehaviour
{

    public float gameSpeed;
    public int points = 0;
    public float speed;
    public int failCounter;
    public int pointsToReach;
    int pointReaching;
    public float wallLeft = -80.0f;
    public float wallRight = 80.0f;
    float speedDirection = 1.0f;
    private float timer;
    Vector3 startX;
    private float waitTimer = 0.5f;
    Vector2 speedAmount;
    public GameObject cubeCollection;

    void Start()
    {
        speed = gameSpeed;
        points = 0;
        print(speed);
        cubeCollection.SetActive(false);
        startX = new Vector3(-70, transform.position.y, transform.position.z);
    }
    void FixedUpdate()
    {
        timer += Time.deltaTime;
        if (timer >= waitTimer)
        {
            speed = gameSpeed;
            
        }
        pointReaching = points;
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
        if (pointReaching == pointsToReach)
        {
            pointReaching = 0;
            points = 0;
            failCounter = 0;
            cubeCollection.SetActive(false);
        }
        if (failCounter == pointsToReach)
        {
            pointReaching = 0;
            points = 0;
            failCounter = 0;
            cubeCollection.SetActive(false);
        }
    }
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "CubeRight")
        {
            print("hello");
            if (Input.GetKeyDown("space") && speed >= 50)            
            {
                points += 1;
                gameObject.transform.position = startX;
                if (speedDirection == -1.0f)
                {
                    speedDirection = 1.0f;
                }
                else if (speedDirection == 1.0f)
                {
                    speedDirection = -1.0f;
                }
            }
        }
        if(other.gameObject.name == "CubeWrong1" || other.gameObject.name == "CubeWrong2" || other.gameObject.name == "CubeWrong3" || other.gameObject.name == "CubeWrong4")
        {
            if(Input.GetKeyDown("space") && speed >= 50)
            {
                gameObject.transform.position = startX;
            }
        }
    }
}