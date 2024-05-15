using TMPro;
using UnityEngine;
using UnityEngine.UI;

//Pulled this from the ZenGarden script

public class TextManager : MonoBehaviour
{
    public TextMeshProUGUI displayText; //Using textmeshPro as requested from Proffesor Roy, to look better for the user

    void Start()
    {
        SetText("Help the fellow Aliens!"); //Just simply setting the intial text
    }

    public void SetText(string text) //This method works with my program when I call it in my code. I will pass the parameter the string that I want to be displayed
        //With the textMeshPro and whatever I wanted passed it will then display it. 
    {
        displayText.text = text;
    }

}

