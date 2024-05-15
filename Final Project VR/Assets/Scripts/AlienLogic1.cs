using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AlienLogic1 : MonoBehaviour
{
    public TextManager textManager;
    public ScoreManager scoreManager;
    public bool hasCollided; //Creating a bool to track if it has been collided or not

    private void Start()
    {
        hasCollided = false; //Setting it intially to false
    }

    private void OnCollisionEnter(Collision collision) 
    {
        GameObject otherObject = collision.gameObject; //Just saying if there is a collsion then we are assigning it to the otherObject variable

        if (otherObject.name == "PlayerController Variant") //Doing this to ensure that only when the Player hits the alien is does the rest of the code
        {
            if (hasCollided == false) //So if the player has not collided yet since we intially set the variable to false
            {
                scoreManager.IncrementScore(); //incremetns the scrore
                hasCollided = true; //And makes the bool true indicating that there has been a collsion
            }
            if (hasCollided == true) //If a collsion has already happened
            {
                textManager.SetText("You found an easter egg, here is a free point not happening again with me though."); //Displays this message so they can only do it once with the interaction of the alien
            }
        }
       
       

    }

}
