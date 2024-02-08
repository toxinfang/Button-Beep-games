using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool paused = false;
    public GameObject PauseMenuCanvas;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (paused)
            {
                Play();
            }
            else
            {
                Stop();
            }
        }
    }
<<<<<<< Updated upstream
    //EA- I changed the code a little since we aren't able to
    // click the button due to the camera
    public void Pause()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            PausePanel.SetActive(true);
            Time.timeScale = 0;

        }
        else
        {
            PausePanel.SetActive(false);
            Time.timeScale = 1;
        }
     
    } 
  

    //public void Continue()
   // {
      //  PausePanel.SetActive(false);
        //Time.timeScale = 1;
    //}
}
=======

    void Stop()
    {
        PauseMenuCanvas.SetActive(true);
        Time.timeScale = 0f;
        paused = true;
    }

    public void Play()
    {
        PauseMenuCanvas.SetActive(false);
        Time.timeScale = 1f;
        paused = false;
    }

    void MainMenuButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
>>>>>>> Stashed changes
