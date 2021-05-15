using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangingText : MonoBehaviour

{
    public Text ScreenText;
    public float timeRemaining = 660;
    public bool timerIsRunning = true;

    private void Start()
    {
        timerIsRunning = true;
    }

    void Update()
    {
        timeRemaining -= Time.deltaTime;
        if (timerIsRunning)
        {
            if (timeRemaining < 650 && timeRemaining > 640)
            {
                ScreenText.text = "We're thrilled to have you onboard as our newest ensign!";
            }
            if (timeRemaining < 640 && timeRemaining > 630)
            {
                ScreenText.text = "Unfortunatley, you have managed to lock yourself in this room.";
            }
            if (timeRemaining < 630 && timeRemaining > 620)
            {
                ScreenText.text = "If you can't get out in 10 minutes, your superiors will be mad!";
            }
            if (timeRemaining < 620 && timeRemaining > 610)
            {
                ScreenText.text = "Solve the puzzles around the room to find a way out.";
            }
            if (timeRemaining < 610 && timeRemaining > 600)
            {
                ScreenText.text = "Good luck, ensign!";
            }
            if (timeRemaining < 600 && timeRemaining > 0)
            {
                    ScreenText.text = string.Format("{0:N2}", timeRemaining);
            }
            //timeRemaining = 0;
            //timerIsRunning = false;
        }
    }
}
