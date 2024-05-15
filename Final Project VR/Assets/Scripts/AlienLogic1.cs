using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AlienLogic1 : MonoBehaviour
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
        GameObject otherObject = collision.gameObject;

        if (otherObject.name == "PlayerController Variant")
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

}
