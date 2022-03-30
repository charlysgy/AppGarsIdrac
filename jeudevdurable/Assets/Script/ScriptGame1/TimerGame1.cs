using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerGame1 : MonoBehaviour
{
    [SerializeField] Text timerText;
    [SerializeField] Text ScoreText;
    [SerializeField] Text LivesText;
    [SerializeField] GameObject LostCanvasGame1;
    [SerializeField] GameObject WinCanvasGame1;

    public int score = 0;
    public int lives = 3;
    public float time = 20f;
    private bool hasFinished = false;

    private void Update()
    {
        // décompteur
        if (time >= 0 && !hasFinished && lives > 0)
        {
            time -= Time.deltaTime;

            if (score >= 5)
            {
                // Win condition
                hasFinished = true;
                WinCanvasGame1.SetActive(true);
            }
        }
        if (lives <= 0 || time <= 0 && !hasFinished)
        {
            // Loose Condition
            hasFinished = true;
            LostCanvasGame1.SetActive(true);

        }
        var seconds = time % 60;

        // print timer
        timerText.text = (System.Math.Round(seconds, 2) + " s");
        ScoreText.text = (score + " / 5");
        LivesText.text = ($"Vies : {lives}");
    }
}
