using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbScoreTrack : MonoBehaviour
{
    public TextManager textManager;
    public ScoreManager scoreManager;

    

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            
            scoreManager.IncrementScore();
            textManager.SetText("Thank you!");
            Destroy(gameObject); 
            
        }
        if (collision.gameObject.CompareTag("Destroy"))
        {
            scoreManager.DecrementScore();
            textManager.SetText("NOOOO! Help us");
            Destroy(gameObject);

        }
    }
}
