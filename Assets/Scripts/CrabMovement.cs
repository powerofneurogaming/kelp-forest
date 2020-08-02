using UnityEngine;
using System.Collections;

public class CrabMovement : MonoBehaviour {
    public float goonSpeed;
    public bool hitObject = true;
    public int coinValue = 2;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            ScoreManager.instance.ChangeScore(coinValue);
        }
    }

    void Update()
    {
        transform.Translate(Vector3.right * goonSpeed * Time.deltaTime);

        Vector3 right = transform.TransformDirection(Vector3.right);
        }
    }