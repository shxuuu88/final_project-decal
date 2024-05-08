using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;
    public int playerScore = 0;

    private ScoreDisplay scoreDisplay;

    void Awake()
    {
        // Singleton pattern to ensure one ScoreManager instance
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);

        // Find the ScoreDisplay component
        scoreDisplay = FindObjectOfType<ScoreDisplay>();
    }

    public void IncrementPlayerScore()
    {
        playerScore += 1;
        Debug.Log("Player Score: " + playerScore);
        // Update the UI score display
        if (scoreDisplay != null)
            scoreDisplay.UpdateScoreDisplay(playerScore);
    }
}


