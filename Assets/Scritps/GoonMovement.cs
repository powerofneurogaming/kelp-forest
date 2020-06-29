using UnityEngine;
using System.Collections;

public class GoonMovement : MonoBehaviour {
    public float raycastLength;

    public float goonSpeed;

    public bool hitObject = false;

    void Update()
    {
        transform.Translate(Vector3.right * goonSpeed * Time.deltaTime);

        Vector3 right = transform.TransformDirection(Vector3.right);

        // if (hitObject == false Physics.Raycast(transform.position, left, raycastLength))
        // {
        //     print("HIT");
        //     hitObject = false;
        //     }
        }
    }