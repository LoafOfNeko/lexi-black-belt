using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class textBoxControl : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI text;
    [SerializeField] private TextMeshProUGUI playerName;
    [SerializeField] private GameObject holder;
    [SerializeField] private GameObject Button;

    private string[] currentTexts;

    private int i = 0;
    private int currentLetter = 0;


    private void CheckContinueButton()
    {
        if (i == currentTexts.Length - 1)
        {
            Button.SetActive(false);
        }
        else
        {
            Button.SetActive(true);
        }
    }

    private void CheckClose()
    {
        if (i == currentTexts.Length)
        {
            TurnOff();
        }
    }

    public void TurnOn(string Name, string[] Texts)
{

        currentTexts = Texts;
        holder.SetActive(true);
        text.text = Texts[0];
        CheckContinueButton();
        playerName.text = Name;
}

        

    public void TurnOff()
    {
        i = 0;
        holder.SetActive(false);
         currentLetter = 0;
    }

    void Update()
    {
        //reset the textbox for the next sentence
        if (Input.GetKeyDown("space"))
        {
            i += 1;
            CheckContinueButton();
            CheckClose();
            //text.text = currentTexts[i].Substring(0, currentLetter);
            currentLetter = 0;
        }
        if (holder.active == true){
            text.text = currentTexts[i].Substring(0, currentLetter);
            if(currentLetter < currentTexts[i].Length)
                currentLetter++;
            }
        }
}
//cheese