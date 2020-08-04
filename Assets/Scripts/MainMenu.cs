using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Information()
    {
        SceneManager.LoadScene("Information Scene");    //Clicking Information button moves to Info scene
    }

    public void Menu()
    {
        SceneManager.LoadScene("Menu");    //Clicking Main Menu button moves to menu scene
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);     //This transitions to next scene.
    }

    public void QuitGame ()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
