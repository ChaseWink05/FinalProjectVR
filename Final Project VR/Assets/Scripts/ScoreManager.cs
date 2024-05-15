using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TextManager textManager;
    public int treatCounter = 0;
    public int score = 0;
    public TextMeshProUGUI Score;



    public void IncrementScore()
    {
        score += 1;
        UpdateScoreDisplay();
        if (score == 3)
        {
            LoadNextScene();
        }

    }
    public void DecrementScore()
    {
        if (score == 0)
        {
            score = 0;
            UpdateScoreDisplay(); 
        }else 
            score -= 1;
        UpdateScoreDisplay();
    }
    
    void Start()
    {
        UpdateScoreDisplay();
    }

    void UpdateScoreDisplay()
    {
        Score.text = "Score: " + score;
    }

    void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int nextSceneIndex = currentSceneIndex + 1;
        SceneManager.LoadScene(nextSceneIndex);
    }
}
