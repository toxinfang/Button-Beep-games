using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //This gives us access to our UI elements so we can display the text. Only using it internally? Don't need it.
using TMPro;

//This is a basic timer good for counting down seconds.
//It counts down as full seconds and stops immediately when you get to 0

public class Timer : MonoBehaviour
{
    public float timeRemaining = 30f;
    public float endTime = 0f;
    public bool timerRunning = false;
    public TextMeshProUGUI timerText;

    // Start is called before the first frame update
    void Start()
    {
        timerRunning = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (timerRunning)
        {
            if (timeRemaining > endTime)
            {
                timeRemaining -= Time.deltaTime;
                timerText.text = ("Time: ") + Mathf.FloorToInt(timeRemaining + 1).ToString();
            }
            else
            {
                timerRunning = false;
                timeRemaining = 0;
                timerText.text = ("Time: ") + Mathf.FloorToInt(timeRemaining).ToString();
            }
        }

        
    }
}
