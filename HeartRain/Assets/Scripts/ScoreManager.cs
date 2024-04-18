using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoSingleton<ScoreManager>
{
    [SerializeField] private int Score { get; set; }
    [SerializeField] private int EndGameScore { get; set; }

    [SerializeField] private static int HighScore { get; set; }

    private void OnEnable()
    {
        PlayerObserver.HeartHere += HeartHere_ScoreManager;
        PlayerObserver.CircleHere += CircleHere_ScoreManager;
    }
    private void OnDisable()
    {
        PlayerObserver.HeartHere -= HeartHere_ScoreManager;
        PlayerObserver.CircleHere -= CircleHere_ScoreManager;
    }

    public void HeartHere_ScoreManager()
    {
        Score += 10;
    }
    public void CircleHere_ScoreManager()
    {
        Score -= 2;
    }
    private void Update()
    {
    }
    public void EndGame()
    {
        EndGameScore = Score;
        if (PlayerPrefs.GetInt("HighScore") < EndGameScore)
        {
            HighScore = EndGameScore;
            PlayerPrefs.SetInt("HighScore", HighScore);
        }
        ResetTheScore();
    }
    public void ResetTheScore()
    {
        Score = 0;
    }
    public int GetScore()
    {
        return Score;
    }
}
