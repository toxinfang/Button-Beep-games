using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PauseManager : MonoBehaviour
{
    public bool isPaused = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Check for the 'P' key press
        if (Input.GetKeyDown(KeyCode.P)){
            // Toggle pause state
            TogglePause();
        }
    }

    private void TogglePause()
    {
        // Toggle the pause state
        isPaused = !isPaused;

        // If the game is paused, freeze time
        if (isPaused)
        {
            Debug.Log("Paused");
            Time.timeScale = 0f;
        }
        else
        {
            // If the game is unpaused, resume time
            Debug.Log("Unpaused");
            Time.timeScale = 1f;
        }
    }
}
