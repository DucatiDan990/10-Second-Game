using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GuessingScript : MonoBehaviour
{

    public InputField iField;
    public string theInput;
    public string[] answers;
    public List <string> correctGuesses = new List<string>();
    public Text GuessedWords;
    public int score;
      //  public GameObject[]

    public void Update()
    {
        if (Input.GetKeyDown (KeyCode.Return))
        {
            checkInput();
        }

        if (score > 10)
        {
            SceneManager.LoadScene("Win Scene");
        }
    }
    
    public void checkInput()
    {
        theInput = iField.text;

        if (!correctGuesses.Contains(theInput))
        {
            foreach (string a in answers)
            {
                if (theInput == a)
                {
                    Debug.Log("You Won");
                    GuessedWords.text += " " + a + ",";
                    iField.text = "";
                    score += 1;
                    correctGuesses.Add(theInput);
                }
                else
                {
                    iField.text = "";
                }
            }
        }
        else
        {
            iField.text = "";
        }

    }


}
