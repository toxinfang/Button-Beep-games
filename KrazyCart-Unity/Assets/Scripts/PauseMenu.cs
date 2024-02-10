using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject PausePanel;

    // Update is called once per frame
    void Update()
    {
        
    }
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
