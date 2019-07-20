using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int max;
    int min;
    int guess;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Welcome to Number Wizard! Yey!");
        Debug.Log("Pick a number.");
        Debug.Log("Highest number is: " + max);
        Debug.Log("Lowest number is: " + min);
        Debug.Log("I think your number is 500. Tell me if your number is higher or lower.");
        Debug.Log("Press Up Arrow = Higher, Down Arrow = Lower, Enter = Correct.");

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            guess = (max + min) / 2;
            Debug.Log(guess);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            guess = (max + min) / 2;
            Debug.Log(guess);
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Enter key was pressed");
        }
    }

    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = 500;

        Debug.Log("Welcome to Number Wizard! Yey!");
        Debug.Log("Pick a number.");
        Debug.Log("Highest number is: " + max);
        Debug.Log("Lowest number is: " + min);
        Debug.Log("Is your number " + guess + " ? Tell me if it is higher or lower.");
        Debug.Log("Press Up Arrow = Higher, Down Arrow = Lower, Enter = Correct.");
        max = max + 1;
    }

    void NextGuess()
    {
        guess = (max + min) / 2;
        Debug.Log("Is your number " + guess + "? Tell me if it is higher or lower.");
    }
}

        StartGame();
            NextGuess();
            NextGuess();
            Debug.Log("Thanks for game!");
            StartGame();