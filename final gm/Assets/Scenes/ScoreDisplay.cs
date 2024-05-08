using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
    public Text scoreText; // Reference to the UI Text element

    void Start()
    {
        // Initialize the score display to zero
        UpdateScoreDisplay(0);
    }

    public void UpdateScoreDisplay(int newScore)
    {
        // Update the text to reflect the current score
        scoreText.text = "Score: " + newScore.ToString();
    }
}

