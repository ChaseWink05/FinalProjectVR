using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TextManager : MonoBehaviour
{
    public TextMeshProUGUI displayText;

    void Start()
    {
        SetText("Help the fellow Aliens!");
    }

    public void SetText(string text)
    {
        displayText.text = text;
    }

}

