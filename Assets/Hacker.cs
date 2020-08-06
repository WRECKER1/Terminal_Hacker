using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    int level;
    enum Screen { MainMenu, Password, Win };
    Screen currentScreen;

    void Start()
    {
        mainMenu();
    }

    void Update()
    {

    }

    void mainMenu()
    {
        currentScreen = Screen.MainMenu;
        Terminal.ClearScreen();
        Terminal.WriteLine("What would you like to hack into?\nPress 1 for the local library\nPress 2 for the police station\nPress 3 for the NASA\nEnter your selection:");
    }

    void OnUserInput(string input)
    {
        if (input == "menu") mainMenu();
        if (currentScreen == Screen.MainMenu)
        {
            if (input == "1" || input == "2" || input == "3")
            {
                currentScreen = Screen.Password;
                level = int.Parse(input);
                startGameLevel(level);
            }
            else if (input.Length == 4) Terminal.WriteLine("Not your credit card password fool");
            else Terminal.WriteLine("Please choose a valid input");
        }
        else if (currentScreen == Screen.Password)
        {
            ;
        }
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
