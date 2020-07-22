﻿using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public float speed;
    private Rigidbody2D rb2d;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D> ();
    }

    void Update()
    {
        float moveHorizontal = Input.GetAxis ("Horizontal");

        float moveVertical = Input.GetAxis ("Vertical");

        Vector2 movement = new Vector2 (moveHorizontal, moveVertical);

        rb2d.AddForce (movement * speed);
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.CompareTag("Coin")) 
        {
            Destroy(other.gameObject);
        }

                if(other.gameObject.CompareTag("Powerup")) 
        {
            Destroy(other.gameObject);
        }
    }
}