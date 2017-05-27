using Assets.Classes;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class registerButtonService : MonoBehaviour {

    public Button button;
    public InputField inputField;
    private Player newPlayer;


    public void registerButtonListener()
    {
        string buttonText = button.GetComponentInChildren<Text>().text;
        string inputFieldText = inputField.GetComponentInChildren<Text>().text;
        switch (buttonText)
        {
            case "Confirm username":
                {
                    newPlayer = new Player(inputFieldText);
                    button.GetComponentInChildren<Text>().text = "Confirm password";
                    break;
                }
            case "Confirm password":
                {
                    newPlayer.setPassword(inputFieldText);
                    button.GetComponentInChildren<Text>().text = "Create user";
                    break;
                }
            case "Create user":
                {
                    try
                    {
                        int age = Int32.Parse(inputFieldText);
                        newPlayer.setAgeGroup(age);
                        button.GetComponentInChildren<Text>().text = "Create user";
                    } catch (Exception e)
                    {
                        
                    }
                    
                    break;
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
