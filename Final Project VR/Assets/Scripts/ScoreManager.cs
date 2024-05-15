using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

//Pulled this from the ZenGarden project. It is the exact same but the only thing I changed was the decrementscore method and textMeshPro

public class ScoreManager : MonoBehaviour
{
    public TextManager textManager;
    public int treatCounter = 0;
    public int score = 0;
    public TextMeshProUGUI Score;



    public void IncrementScore()
    {
        score += 1; //Everytime this method is called it increments the score by 1
        UpdateScoreDisplay(); //Updates the score in the display for the user defined later on in the script
        if (score == 3)
        {
            LoadNextScene(); //Load next scene defined later in the script
        }

    }
    public void DecrementScore()
    {
        if (score == 0) //I made this because if the score is zero we dont wanna go into the negatives so if the score is zero we set the score to zero again
        {
            score = 0;
            UpdateScoreDisplay(); 
        }else 
            score -= 1; //however if it is not zero then we decrement and update the scoreboard by 1 
        UpdateScoreDisplay();
    }
    
    void Start()
    {
        UpdateScoreDisplay();
    }

    void UpdateScoreDisplay() //This method is the same logic as the Textmanger essentially but I am not passing a parameter cause everything score related is in this script
    { //Just assigning the varibable and what it is equal to
        Score.text = "Score: " + score;
    }

    void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int nextSceneIndex = currentSceneIndex + 1;
        SceneManager.LoadScene(nextSceneIndex);
    }
}
