using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GuessingScript : MonoBehaviour
{

    public InputField iField;
    public string theInput;
    public string[] answers; 
      //  public GameObject[]

    public void Update()
    {
        if (Input.GetKeyDown (KeyCode.Return))
        {
            checkInput();
        }
    }
    
    public void checkInput()
    {
        theInput = iField.text;

        foreach (string a in answers)
        {
            if(theInput == a)
            {
                Debug.Log("You Won");
            }
        }

    }


}
