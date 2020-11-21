using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int maxGuess = 1000;
    int minGuess = 1;
    int guess = 500;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Welcome to Number Wizard!");
        Debug.Log("Pick a number and don't tell me what it is! I want to guess.");
        Debug.Log("The highest number that you can choose is: " + maxGuess);
        Debug.Log("The lowest number that you can choose is: " + minGuess);
        Debug.Log("Tell me if your number is lower or higher than my guess.");
        Debug.Log("Press the up button for higher, down for lower, and enter for correct.");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("You pressed up.");
            minGuess = guess;
            Debug.Log(guess);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("You pressed down.");
            maxGuess = guess;
            Debug.Log(guess);
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("You pressed enter.");
        }
    }
}
