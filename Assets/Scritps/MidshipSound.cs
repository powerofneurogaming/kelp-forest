using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MidshipSound : MonoBehaviour
{
  public AudioSource someSound;
  public GameObject projectile;
  public float shootForce;
  public static IUpdatable[] updatables;
	
  void Start () {
  }

  public void Update () {
         if (Input.GetKeyDown(KeyCode.Space)) {
             if(!someSound.isPlaying) {
                 someSound.Play();
             }
         }
      
         if (Input.GetKeyUp(KeyCode.Space)) {
             someSound.Stop();
         }
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject shot = GameObject.Instantiate(projectile, transform.position, transform.rotation);
            shot.GetComponent<Rigidbody2D>().AddForce(shot.GetComponent<Transform>().right * PlayerController.instance.transform.localScale.x * shootForce);
            Physics2D.IgnoreCollision(shot.GetComponent<Collider2D>(), PlayerController.instance.GetComponent<Collider2D>());
        }
     }
 }
