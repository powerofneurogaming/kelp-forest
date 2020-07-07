using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MidshipSound : MonoBehaviour
{
  public AudioSource someSound;
  void Start () {
      
  }
  
  void Update () {
         if (Input.GetKeyDown(KeyCode.Space)) {
             if(!someSound.isPlaying) {
                 someSound.Play();
             }
         }
      
         if (Input.GetKeyUp(KeyCode.Space)) {
             someSound.Stop();
         }
     }
 }
