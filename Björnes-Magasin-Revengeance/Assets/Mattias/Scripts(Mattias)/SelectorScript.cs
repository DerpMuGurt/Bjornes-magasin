using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SelectorScript : MonoBehaviour
{

    public float gameSpeed;
    public int points = 0;
    public float speed;
    public int failCounter;
    public int pointsToReach;
    int pointReaching;
    public float wallLeft = 200.0f;
    public float wallRight = 1200.0f;
    float speedDirection = 1.0f;
    private float timer;
    Vector3 startX;
    private float waitTimer = 0.5f;
    Vector2 speedAmount;
    public Canvas cubeCollection;
    public Image cubeWrong1, cubeWrong2, cubeWrong3, cubeWrong4, cubeRight;
    GameObject[] hitBoxes;
    int hitIndex;
    float speedIncrease = 10;
    public float advancedSpeed;
    public bool isAdvanced;
    public Canvas[] canvasList;
    Canvas currentCanvas;
    int canvasInt;
    public GameObject startObject;

    void Start()
    {
        speed = gameSpeed;
        points = 0;
        print(speed);
        cubeCollection.gameObject.SetActive(false);
        startX = new Vector3(-70, transform.position.y, transform.position.z);
        cubeRight = GetComponent<Image>();
        cubeRight.GetComponent<BoxCollider2D>();
        canvasInt = Random.Range(0, canvasList.Length);
        currentCanvas = canvasList[canvasInt];
        currentCanvas.gameObject.SetActive(true);
        print(currentCanvas.name);
    }
    void FixedUpdate()
    {
        timer += Time.deltaTime;
        if (timer >= waitTimer)
        {
            speed = gameSpeed + speedIncrease;

        }
        pointReaching = points;
    }


    void Update()
    {
        speedAmount.x = speedDirection * speed * Time.deltaTime;
        if (speedDirection > 0.0f && transform.position.x > wallRight)
        {
            speedDirection = -1.0f;
            speedIncrease = 0;
        }
        else if (speedDirection < 0.0f && transform.position.x <= wallLeft)
        {
            speedDirection = 1.0f;
            speedIncrease = 0;
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
            cubeCollection.gameObject.SetActive(false);
            startObject.SetActive(true);
        }
        if (failCounter == pointsToReach)
        {
            pointReaching = 0;
            points = 0;
            failCounter = 0;
            cubeCollection.gameObject.SetActive(false);
        }
        if (isAdvanced)
        {
            speedIncrease += advancedSpeed;
        }
        else
        {
            speedIncrease++;
        }
    }
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "ImageRight")
        {
            print("hello");
            if (Input.GetKeyDown("space") && speed >= 50)
            {
                points += 1;
                speedIncrease = 0;
                currentCanvas.gameObject.SetActive(false);
                canvasInt = Random.Range(0, canvasList.Length);
                currentCanvas = canvasList[canvasInt];
                currentCanvas.gameObject.SetActive(true);
            }
        }
        if (other.gameObject == cubeWrong1 || other.gameObject == cubeWrong2 || other.gameObject == cubeWrong3 || other.gameObject == cubeWrong4)
        {
            if (Input.GetKeyDown("space") && speed >= 50)
            {

            }
        }
    }
}