using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SetInputMenu : MonoBehaviour {

    public EventSystem eventSystem;
    public GameObject selectedObject;

    private bool buttonSelected;

    bool isWorking;


    void Start()
    {
    }
    void OnEnable()
    {
        eventSystem.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(selectedObject);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0)|| Input.GetKeyDown(KeyCode.Mouse1) || Input.GetKeyDown(KeyCode.Mouse2))
        {
            EventSystem.current.SetSelectedGameObject(selectedObject);
        }
    }

    private void OnDisable()
    {
        EventSystem.current.SetSelectedGameObject(selectedObject);
        buttonSelected = false;
    }
}
