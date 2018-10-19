using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    Image sr;
    Color old;

    public KeyCode key;

    bool active = false;

    GameObject NoteE;


    void Awake()
    {
        sr = GetComponent<Image>();
    }

    void Start()
    {
        old = sr.color;    
    }

    void Update()
    {
        if (Input.GetKeyDown(key))
            StartCoroutine(Pressed());

        if (Input.GetKeyDown(key) && active)
        {
            Destroy (NoteE);
            active = false;
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        active = true;
        if (collision.gameObject.tag == "NoteE")
        {
            NoteE = collision.gameObject;
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        active = false;
    }

    IEnumerator Pressed()
    {
        sr.color = new Color(0, 0, 0);
        yield return new WaitForSeconds(0.05f);
        sr.color = old;
    }

}
