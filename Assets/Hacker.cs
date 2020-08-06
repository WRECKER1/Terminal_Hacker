using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    int level;

    void Start()
    {
        startSequence();
        startGameLevel(level);
    }

    void Update()
    {

    }

    void startSequence()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("What would you like to hack into?\nPress 1 for the local library\nPress 2 for the police station\nPress 3 for the NASA\nEnter your selection:");
    }

    void OnUserInput(string input)
    {
        if (input == "menu") startSequence();
        else if (input == "1" || input == "2" || input == "3")
        {
            level = int.Parse(input);
            startGameLevel(level);
        }
        else if (input.Length == 4) Terminal.WriteLine("Not your credit card password fool");
        else Terminal.WriteLine("Please choose a valid input");

    }


    void startGameLevel(int level)
    {
        Terminal.WriteLine("You have chosen level " + level);
        if (level == 1)
        {; }
        else if (level == 2)
        {
            ;
        }
        else if (level == 3)
        {
            ;
        }
    }
}
