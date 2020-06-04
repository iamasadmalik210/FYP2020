using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer_Text : MonoBehaviour

{
    public Text timer_text;
    private float startTime;
    public Text displayGameOver;
    private bool gameisover = false;

    // Start is called before the first frame update
    void Start()
    {
        startTime = 10f;

        
        
    }

    // Update is called once per frame
    void Update()
    {
        float t = startTime - Time.time;

        string minutes = ((int)t / 60).ToString();
        string seconds = (t % 60).ToString("f2");

        timer_text.text = "Time "+ minutes + ":" + seconds;

        if(t<0.0)
        {
            EndGame();
        }


    }
    void EndGame()
    {
        Time.timeScale = 0;
        gameisover = true;
        displayGameOver.text = "GameOver";
    }
}
