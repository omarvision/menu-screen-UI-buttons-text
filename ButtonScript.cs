using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  //for SceneManager

public class ButtonScript : MonoBehaviour
{
    public void Play_Click()
    {
        //Note: scene must be added to Unity project's Build Settings in order for LoadScene() to work.
        SceneManager.LoadScene("scene");
    }
    public void Quit_Click()
    {
        //Note: Quit only works with the Built version of the game (not the game playing from within Unity)
        Debug.Log("You Pressed Quit Button");
        Application.Quit();
    }
}