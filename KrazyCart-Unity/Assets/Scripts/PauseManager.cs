using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;// Ignore error, it still works.
public class PauseManager : MonoBehaviour
{
    public bool isPaused = false;
    public GameObject backGround;// This is for the Pause Menu Background
    public TextMeshProUGUI text;// Ignore error, it still works.
    public GameObject menuButton;
    public AudioSource soundClip;
    public AudioClip soundEffect;
    public ThirdPersonControllerM controller;// Upon pausing, should prevent player from moving, as well as pausing camera movement.

    // Start is called before the first frame update
    void Start()
    {
        text.text = ("");// Deactivate both text and background upon starting the level.
        backGround.SetActive(false);
        Time.timeScale = 1f;// Ensures the game isn't pause apon starting.
        menuButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        // Check for the 'P' key press
        if (Input.GetKeyDown(KeyCode.Escape)){
            // Toggle pause state
            TogglePause();
            soundClip.PlayOneShot(soundEffect); // Plays the sound effect after pressing the Pause key
        }
    }

    private void TogglePause()
    {
        // Toggle the pause state
        isPaused = !isPaused;

        // If the game is paused, freeze time
        if (isPaused)
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            Time.timeScale = 0f;
            text.text = ("Paused");// Can be change to say something else.
            backGround.SetActive(true);// Can make the background appear upon pausing.
            menuButton.SetActive(true);
            controller.canMove = false;// Pauses player and camera.
        }
        else
        {
            // If the game is unpaused, resume time
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
            Time.timeScale = 1f;
            text.text = ("");// Make the text disappear after unpausing.
            backGround.SetActive(false);// Make the background disappear after unpausing.
            menuButton.SetActive(false);
            controller.canMove = true; ;// Unpauses player and camera.
        }
    }
}
