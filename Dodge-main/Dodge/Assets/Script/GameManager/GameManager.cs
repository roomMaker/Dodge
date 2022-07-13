using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public TimerText TimerTextUI;
    public GameObject GameOverUI;
    public BestTime BestTime;

    private bool _isOver;
    private void Update()
    {
        if(/*_isOver && */Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(0);
            _isOver = false;
        }
    }
    public void End()
    {
        TimerTextUI.IsOn = false;

        int bestTime = (int)TimerTextUI.SurvivalTime;
        int saveBestTime = PlayerPrefs.GetInt("최고", 0);
        if (saveBestTime > bestTime)
        {
            bestTime = saveBestTime;
        }
        PlayerPrefs.SetInt("최고",bestTime);

        BestTime.UpdateBestTime((int)TimerTextUI.SurvivalTime);
        GameOverUI.SetActive(true);
        _isOver = true;
    }

}
