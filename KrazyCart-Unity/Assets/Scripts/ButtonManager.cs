using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ButtonManager : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync(1); // this is for the play button it loads the main scene
        
    }


    public void QuitGame()
    {
        Application.Quit(); // this is for the quit button it quits the application
    }

}


