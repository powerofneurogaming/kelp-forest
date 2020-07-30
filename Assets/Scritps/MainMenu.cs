using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //public Animator transition;
    //public float transitionTime = 1f;
    //public GameObject Playbutton;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetMouseButtonDown(0))
        //{
        //    PlayGame();
        //}
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);     //This transitions to next scene.
    }

    //IEnumerator LoadLevel(int levelIndex)
    //{
    //    transition.SetTrigger("Start"); //Play animation

    //    yield return new WaitForSeconds(transitionTime); //Wait

    //    SceneManager.LoadScene(levelIndex); //Load scene
    //}

    public void QuitGame ()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
