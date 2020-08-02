using UnityEngine;
using System.Collections;

public class GoonMovement : MonoBehaviour {
    public float raycastLength;

    public float goonSpeed;

    public bool hitObject = false;
    public Rigidbody2D rigid;

    void Start ()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        transform.Translate(Vector3.right * goonSpeed * Time.deltaTime);

        Vector3 right = transform.TransformDirection(Vector3.right);
    }

    void OnCollisionEnter2D (Collision2D coll)
    {
        if (coll.gameObject.name.Contains("Projectile"))
        {
            Destroy(coll.gameObject);
        }
    }
}