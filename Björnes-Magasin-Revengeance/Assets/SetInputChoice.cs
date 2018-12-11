using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SetInputChoice : MonoBehaviour
{

    public EventSystem eventSystem;
    public GameObject selectedObject;

    GameObject buttonImage;

    private bool buttonSelected;

    bool isWorking;


    void Start()
    {

    }
    void OnEnable()
    {
        buttonSelected = true;
        //eventSystem.SetSelectedGameObject(null);
        //EventSystem.current.SetSelectedGameObject(selectedObject);
        //Debug.Log("Hello");
    }

    void Update()
    {
        if(buttonSelected == true)
        {
            eventSystem.SetSelectedGameObject(null);
            EventSystem.current.SetSelectedGameObject(selectedObject);
            buttonSelected = false;
        }

            if (Input.GetKeyDown(KeyCode.Mouse0) || Input.GetKeyDown(KeyCode.Mouse1) || Input.GetKeyDown(KeyCode.Mouse2))
            {
                EventSystem.current.SetSelectedGameObject(selectedObject);
            }
    }

    private void OnDisable()
    {
        //buttonImage = GameObject.FindWithTag("ButtonImage");
        //buttonImage.SetActive(false);
        EventSystem.current.SetSelectedGameObject(selectedObject);
    }
}
