using UnityEngine;
using UnityEngine.UI;

public class EndGame : MonoBehaviour
{
    //Source for this was our first project with the scavenger hunt that Ivy and I created. We used this logic to quit the actual game for the button.
    // This method is called when the Quit button is clicked
    public void QuitApplication()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false; // If running in the Unity Editor, stop playing
#else
            Application.Quit(); // If running, quit the application
#endif
    }
}
 