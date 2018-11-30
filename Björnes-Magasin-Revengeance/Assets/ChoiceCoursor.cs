using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class ChoiceCoursor : MonoBehaviour
{

    public GameObject coursor;


    public void OnSelect(BaseEventData eventData)
    {
        coursor.SetActive(true);
        Debug.Log(this.gameObject.name + " was selected");
    }
    public void OnDeselect(BaseEventData eventData)
    {
        coursor.SetActive(false);

    }
}