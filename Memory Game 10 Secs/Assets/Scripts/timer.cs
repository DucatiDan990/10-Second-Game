using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    public float Timer = 10;
    public Text TimerText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TimerText.text = (Timer).ToString("0");
        if (Timer > 0)
        {
            Timer -= Time.deltaTime;
        }
        else
        {
            SceneManager.LoadScene("GuessingScene");
            Debug.Log("End of timer");
        }
    }
}
