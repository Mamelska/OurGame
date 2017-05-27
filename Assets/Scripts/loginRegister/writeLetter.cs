using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class writeLetter : MonoBehaviour {

    public Button letterButton;
    public InputField inputField;



    public void onClickListener()
    {
        string inputFieldText = inputField.GetComponentInChildren<Text>().text;
        string letter = letterButton.GetComponentInChildren<Text>().text;
        // dac zeby dopisywalo * a wartość sobie jakoś zapamiętać? Ale niby jak, te obiekty są bez powiązań
        //inputField.GetComponentInChildren<Text>().text = "la";
        //inputField.GetComponentInChildren<Text>().text = letterButton.GetComponentInChildren<Text>().text;
        if (inputFieldText == "Input password")
        {
            
            if (letter == "Erase")
            {
                inputField.GetComponentInChildren<Text>().text = "";
            }
            else
            {
                inputField.GetComponentInChildren<Text>().text = letter;
            }
        } else
        {
            
            if(letter == "Erase")
            {
                int count = inputFieldText.Length;
                string erasedText = inputFieldText.Remove(count - 1, 1);
                inputField.GetComponentInChildren<Text>().text = erasedText;
            } else
            {
                inputField.GetComponentInChildren<Text>().text += letter;
            }
        }
        
        
    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
