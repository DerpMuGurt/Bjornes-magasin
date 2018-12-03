using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SetInputMenu : MonoBehaviour {

    public EventSystem eventSystem;
    public GameObject selectedObject;

    private bool buttonSelected;
    bool isWorking;


    void Update()
    {
        if (Input.GetAxisRaw("Vertical") != 0 && buttonSelected == false && isWorking == true)
        {
            eventSystem.SetSelectedGameObject(selectedObject);
            buttonSelected = true;
        }

        if (EventSystem.current.currentSelectedGameObject == null)
        {
            isWorking = false;
            eventSystem.SetSelectedGameObject(selectedObject);
            isWorking = true;
        }
    }

    private void OnDisable()
    {
        buttonSelected = false;
    }
}
