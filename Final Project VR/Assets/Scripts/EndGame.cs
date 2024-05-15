using UnityEngine;
using UnityEngine.UI;

public class EndGame : MonoBehaviour
{
    // This method is called when the Quit button is clicked
    public void QuitApplication()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false; // If running in the Unity Editor, stop playing
#else
            Application.Quit(); // If running as a standalone build, quit the application
#endif
    }
}
 