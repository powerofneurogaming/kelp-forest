using UnityEngine;
using System.Collections;

public class SharkMovement : MonoBehaviour {
    public float raycastLength;

    public float goombaSpeed;

    public bool hitObject = false;

    void Update()
    {
        transform.Translate(Vector3.right * goombaSpeed * Time.deltaTime);

        Vector3 right = transform.TransformDirection(Vector3.right);

        // if (hitObject == false Physics.Raycast(transform.position, left, raycastLength))
        // {
        //     print("HIT");
        //     hitObject = false;
        //     }
        }
    }