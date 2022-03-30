using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerGame2 : MonoBehaviour
{
    [SerializeField] Text timerText;
    [SerializeField] Text ScoreText;
    [SerializeField] GameObject gameOverCanvas;
    [SerializeField] GameObject winCanvas;

    public int score = 0;
    public float time = 20f;
    private bool hasFinished = false;

    private void Update()
    {
        // décompteur
        if (time >= 0 && !hasFinished)
        {
            time -= Time.deltaTime;

            if (score >= 5)
            {
                // Win condition
                hasFinished = true;
                winCanvas.SetActive(true);
            }
        }
        if (time <= 0 && !hasFinished)
        {
            // Loose Condition
            hasFinished = true;
            gameOverCanvas.SetActive(true);
           
        }
        var seconds = time % 60;

        // print timer
        timerText.text = (System.Math.Round(seconds, 1) + " s");
        ScoreText.text = (score + " / 5");
    }
}
