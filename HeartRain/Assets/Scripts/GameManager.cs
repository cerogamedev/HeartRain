using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoSingleton<GameManager>
{
    public bool isGameStart = false;

    [Header("Game Info")]
    public float GameDuration;
    [HideInInspector] public float _gameDuration;
    private void OnEnable()
    {
        _gameDuration = GameDuration;
    }
    void Start()
    {
        
    }

    void Update()
    {
        if (isGameStart)
        {
            _gameDuration -= Time.deltaTime;
        }
        if (_gameDuration <= 0)
        {
            isGameStart = false;
            _gameDuration = GameDuration;
            ScoreManager.Instance.EndGame();
        }
    }
    public void StartTheGame()
    {
        isGameStart = true;
        ScoreManager.Instance.ResetTheScore();
    }

}
