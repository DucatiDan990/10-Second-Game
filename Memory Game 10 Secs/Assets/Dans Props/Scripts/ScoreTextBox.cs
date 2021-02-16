using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTextBox : MonoBehaviour
{

    public Text scoreTextBox;
    public GuessingScript gs;

    // Update is called once per frame
    void Update()
    {
        scoreTextBox.text = gs.score + " out of 11 Items";
    }
}
