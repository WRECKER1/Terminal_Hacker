using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    int level;
    string[] passwords = { "donkey", "reference", "neuroscience" };
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
            password = passwords[level-1];
            Terminal.WriteLine("You have chosen level " + level + "\nPlease enter the password: ");
        }
        else Terminal.WriteLine("Please choose a valid input");
    }

    void OnUserInput(string input)
    {
        if (input == "menu")
        {
            currentScreen = Screen.MainMenu;
            showMainMenu();
        }
        if (currentScreen == Screen.MainMenu)
        {
            runMainMenu(input);
        }
        else if (currentScreen == Screen.Password)
        {
            checkPassword(input);
        }
    }

    void winScreen()
    {
        Terminal.WriteLine("WELL DONE! YOU'RE MONKAS");
    }

    void checkPassword(string input)
    {
        if (input == password)
        {
            currentScreen = Screen.Win;
            winScreen();
        }
        else
        {
            Terminal.WriteLine("Wrong password, try again!!");

        }
    }
}
