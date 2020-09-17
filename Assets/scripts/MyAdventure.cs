using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyAdventure : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("Hello World");
        Terminal.WriteLine("Hoi ik zit in de terminal");
        ShowMainMenu();
    }

    void ShowMainMenu()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Welcome to Self Disaster!");
        Terminal.WriteLine("This story can happen to each and everyone of us");
        Terminal.WriteLine("so be aware of your surroundings after you finish this game.");
        Terminal.WriteLine("Type 'start' to start the game.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
