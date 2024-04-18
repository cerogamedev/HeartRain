using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UISystemManager : MonoSingleton<UISystemManager>
{
    public TextMeshProUGUI ScoreText;
    public TextMeshProUGUI HighScoreText;
    public TextMeshProUGUI GameDuration;

    public Button StartButton;
    public GameObject startPanel;
    public Button ExitGameButton;
    private void OnEnable()
    {
        StartButton.onClick.AddListener(() => GameManager.Instance.StartTheGame());
        ExitGameButton.onClick.AddListener(() => ExitTheGame());

    }

    void Update()
    {
        ScoreText.text = "Score : " + ScoreManager.Instance.GetScore().ToString();
        HighScoreText.text = "High Score : " + PlayerPrefs.GetInt("HighScore");
        startPanel.SetActive(!GameManager.Instance.isGameStart);
        GameDuration.text = "Duration : " + GameManager.Instance._gameDuration;
    }
    public void ExitTheGame()
    {
        Application.Quit();
    }
}
