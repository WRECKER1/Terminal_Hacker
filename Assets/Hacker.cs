using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    int level;
    string password;
    enum Screen { MainMenu, Password, Win };
    Screen currentScreen;

    void Start()
    {
        showMainMenu();
    }

    void Update()
    {

    }

    void showMainMenu()
    {
        currentScreen = Screen.MainMenu;
        Terminal.ClearScreen();
        Terminal.WriteLine("What would you like to hack into?\nPress 1 for the local library\nPress 2 for the police station\nPress 3 for the NASA\nEnter your selection:");
    }

    void runMainMenu(string input)
    {
        if (input == "1" || input == "2" || input == "3")
        {
            currentScreen = Screen.Password;
            level = int.Parse(input);
            Terminal.WriteLine("You have chosen level " + level + "\nPlease enter the password: ");
        }
        else if (input.Length == 4) Terminal.WriteLine("Not your credit card password fool");
        else Terminal.WriteLine("Please choose a valid input");
    }

    void OnUserInput(string input)
    {
        if (input == "menu")
        {
            showMainMenu();
        }
        if (currentScreen == Screen.MainMenu)
        {
            runMainMenu(input);
        }
        else if (currentScreen == Screen.Password)
        {
            startGame(input);
        }
    }

    void winScreen()
    {
        Terminal.WriteLine("WELL DONE! YOU'RE MONKAS");
    }

    void startGame(string input)
    {
        checkPassword(input);
    }

    void checkPassword(string input)
    {
        if (input == password)
        {
            winScreen();
        }
        else
        {
            Terminal.WriteLine("Wrong password, try again!!");

        }
    }
}
