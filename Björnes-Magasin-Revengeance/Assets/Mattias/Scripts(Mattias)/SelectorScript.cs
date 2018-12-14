using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Audio;

public class SelectorScript : MonoBehaviour
{

    public float gameSpeed;
    public int points = 0;
    public float speed;
    public int failCounter;
    public int pointsToReach;
    int pointReaching;
    float speedDirection = 1.0f;
    private float timer;
    private float timer2;
    Vector3 startX;
    private float waitTimer = 1.0f;
    Vector2 speedAmount;
    public Canvas cubeCollection;
    public Image cubeWrong1, cubeWrong2, cubeRight;
    GameObject[] hitBoxes;
    int hitIndex;
    float speedIncrease = 10;
    public float advancedSpeed;
    public bool isAdvanced;
    public Canvas[] canvasList;
    Canvas currentCanvas;
    int canvasInt;
    public GameObject startObject;
    public GameObject failObject;
    public Image amazing;
    public Image miss;
    public Image bumperRight;
    public Image bumperLeft;
    public Text pointsText;
    private float successTimer = 3.3f;
    private float failTimer = 3.3f;
    public bool gameStart;
    BakerAnimationScript bakerAnimation;
    public bool hit;
    public bool noHit;


    public Animator animator;

    void Start()
    {
        speed = gameSpeed;
        points = 0;
        print(speed);
        cubeCollection.gameObject.SetActive(false);
        startX = new Vector3(-70, transform.position.y, transform.position.z);
        cubeRight = GetComponent<Image>();
        canvasInt = Random.Range(0, canvasList.Length);
        currentCanvas = canvasList[canvasInt];
        currentCanvas.gameObject.SetActive(true);
        print(currentCanvas.name);
        amazing.GetComponent<Image>();
        amazing.gameObject.SetActive(false);
        miss.GetComponent<Image>();
        miss.gameObject.SetActive(false);
        bumperRight.GetComponent<Image>();
        bumperLeft.GetComponent<Image>();
        gameStart = true;
        bakerAnimation = GetComponent<BakerAnimationScript>();
        
    }
    void FixedUpdate()
    {
        timer += Time.deltaTime;
        if(timer >= successTimer)
        {
            Debug.Log(timer);
            speed = gameSpeed + speedIncrease;
            animator.SetBool("isSuccess", false);
        }
        timer2 += Time.deltaTime;
        if(timer2 >= failTimer)
        {
            Debug.Log(timer2);
            speed = gameSpeed + speedIncrease;
            animator.SetBool("isFail", false);
        }
    }


    void Update()
    {
        
        speedAmount.x = speedDirection * speed * Time.deltaTime;
        
        transform.Translate(speedAmount);

        pointsText.text = points.ToString() + " / ".ToString() + pointsToReach.ToString();
        
        
        pointReaching = points;

        if (pointReaching == pointsToReach)
        {
            pointReaching = 0;
            points = 0;
            failCounter = 0;
            cubeCollection.gameObject.SetActive(false);
            startObject.gameObject.SetActive(true);
            gameStart = false;

        }
        if (failCounter == pointsToReach)
        {
            pointReaching = 0;
            points = 0;
            failCounter = 0;
            cubeCollection.gameObject.SetActive(false);
            failObject.gameObject.SetActive(true);
            gameStart = false;
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
        if (other.gameObject.name == "RightImage")
        {
            print("hello");
            if (Input.GetKeyDown("space") && speed >= 50 || Input.GetKeyDown("joystick button 0") && speed >= 50)
            {
                points += 1;
                speed = 0;
                timer = 0;
                speedIncrease = 0;
                animator.SetBool("isSuccess", true);
                currentCanvas.gameObject.SetActive(false);
                canvasInt = Random.Range(0, canvasList.Length);
                currentCanvas = canvasList[canvasInt];
                currentCanvas.gameObject.SetActive(true);
                amazing.gameObject.SetActive(true);

            }
            StartCoroutine(imageTimer());
        }
        if (other.gameObject.name == "WrongImage1" || other.gameObject.name == "WrongImage2")
        {
            if (Input.GetKeyDown("space") && speed >= 50 || Input.GetKeyDown("joystick button 0") && speed >= 50)
            {
                failCounter += 1;
                speedIncrease = 0;
                speed = 0;
                timer2 = 0;
                hit = false;
                animator.SetBool("isFail", true);
                //  noHit = true;
                miss.gameObject.SetActive(true);
                Debug.Log("Fails: " + failCounter);
            }
            StartCoroutine(wrongTimer());
        }
        if (other.gameObject.name == "BumperRight")
        {
            speedDirection = -1.0f;
            speedIncrease = 0;
        }
        if(other.gameObject.name == "BumperLeft")
        {
            speedDirection = 1.0f;
            speedIncrease = 0f;
        }
    }
    IEnumerator imageTimer()
    {
        yield return new WaitForSeconds(1);
        amazing.gameObject.SetActive(false);
    }
    IEnumerator wrongTimer()
    {
        yield return new WaitForSeconds(1);
        miss.gameObject.SetActive(false);
    }
}