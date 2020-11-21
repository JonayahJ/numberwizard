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
        StartGame();
    }

    void StartGame()
    {
        Debug.Log("Welcome to Number Wizard!");
        Debug.Log("Pick a number and don't tell me what it is! I want to guess.");
        Debug.Log("The highest number that you can choose is: " + maxGuess);
        Debug.Log("The lowest number that you can choose is: " + minGuess);
        Debug.Log("Is your number lower or higher than " + guess + "?");
        Debug.Log("Press the up button for higher, down for lower, and enter for correct.");
        maxGuess += 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            minGuess = guess;
            NextGuess();
            Debug.Log(guess);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            maxGuess = guess;
            NextGuess();
            Debug.Log(guess);
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Nice! I am a number wizard!");
        }
    }

    void NextGuess()
    {
        guess = (maxGuess + minGuess) / 2;
        Debug.Log("Is it higher or lower than " + guess + "?");
    }
}
