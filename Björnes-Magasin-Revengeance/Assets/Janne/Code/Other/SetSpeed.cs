using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetSpeed : MonoBehaviour
{
    Rigidbody2D rb;
    private float speed;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-100, 0);
    }   
}