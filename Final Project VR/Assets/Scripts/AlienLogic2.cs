using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienLogic2 : MonoBehaviour
    //Exact same code from AlienLogic1
{
    public TextManager textManager;
    public ScoreManager scoreManager;
    public bool hasCollided;

    private void Start()
    {
        hasCollided = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (hasCollided == false)
        {
            scoreManager.IncrementScore();
            hasCollided = true;
        }
        if (hasCollided == true)
        {
            textManager.SetText("You found an easter egg, here is a free point not happening again with me though.");
        }


    }

}
