using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbScoreTrack : MonoBehaviour
{
    //Defining these here because I want to update the text for the score and message in this script
    public TextManager textManager;
    public ScoreManager scoreManager;

    

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Floor")) //If there is a collison with a gameobject named floor which I created for the floor then
        {
            
            scoreManager.IncrementScore(); //It increase the score by 1
            textManager.SetText("Thank you!"); //Updates the message
            Destroy(gameObject); //And destroys the orb so it does not go up forever
            
        }
        if (collision.gameObject.CompareTag("Destroy")) //This is the same logic but the destroy tag is assigned to the void at the bottom
        {
            scoreManager.DecrementScore(); //Subtracting the score by 1
            textManager.SetText("NOOOO! Help us"); //updates the text
            Destroy(gameObject); //Destroys the orb 

        }
    }
}
