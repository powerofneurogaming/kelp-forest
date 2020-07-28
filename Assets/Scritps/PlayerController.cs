﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour 
{
    public static PlayerController instance;

    public float speed;
    public BoxCollider2D bc2d;
    private Rigidbody2D rb2d;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D> ();
        instance = this;
    }

    void Update()
    {
        float moveHorizontal = Input.GetAxis ("Horizontal");

        float moveVertical = Input.GetAxis ("Vertical");

        Vector2 movement = new Vector2 (moveHorizontal, moveVertical);
        
        Vector2 temp = gameObject.transform.localScale;

        if ((moveHorizontal < 0) && (gameObject.transform.localScale.x > 0))
        {
            temp.x *= -1;
            transform.localScale = temp;
        }

        if ((moveHorizontal > 0) && (gameObject.transform.localScale.x < 0))
        {
            temp.x *= -1;
            transform.localScale = temp;
        }

        rb2d.AddForce (movement * speed);
        
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.CompareTag("Coin")) 
        {
            Destroy(other.gameObject);
        }
    }
}