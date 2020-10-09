using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyAdventure : MonoBehaviour
{
    private enum States
    {
        start,
        intro,
        turnAround,
        walkingContinues,
    }

    private States currentState = States.start;
    
    // Start is called before the first frame update
    void Start()
    {
        print("Hello World");
        Terminal.WriteLine("Hello, I'm in the terminal.");
        ShowMainMenu();
    }

    void ShowMainMenu()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Welcome to Self Disaster!");
        Terminal.WriteLine("This story can happen to each and everyone of us.");
        Terminal.WriteLine("So be aware of your surroundings after you finish this game.");
        Terminal.WriteLine("Type 'start' to start the game.");
    } 

    void OnUserInput(string input)
    {
        if (currentState == States.start)
        {
            if (input == ("start"))
            {
                currentState = States.intro;
                    StartIntro();
            }else 
            {
                Terminal.WriteLine("Try again!");
            }
        }

        if (currentState == States.intro)
        {
            if (input == "yes")
            {
                currentState = States.walkingContinues;
                StartTurnAround();
            }else if (input == "no")
            {
                currentState = States.walkingContinues;
                StartWalkingContinues();
            }
        }else if (currentState == States.turnAround)
        {
            if (input == "next")
            {
                currentState = States.walkingContinues;
                StartWalkingContinues();
            }else
            {
                Terminal.WriteLine("Wrong input!");
            }
        }

    }

    void StartIntro()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("You just finished work and are on your way home. You know you have to walk a");
        Terminal.WriteLine("shady route but its the only fast way");
        Terminal.WriteLine("to get to your apartment. As you start walking, you feel a presence behind you.");
        Terminal.WriteLine("You stop walking.");
        Terminal.WriteLine("");
        Terminal.WriteLine("Wanna see what's behind you?");
        Terminal.WriteLine("Type yes to see what is there,");
        Terminal.WriteLine("Type no to continue walking...");
    }

    void StartTurnAround()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("You turn around, but there is no one");
        Terminal.WriteLine("You see ruffling in the bushes on the left,");
        Terminal.WriteLine("but luckily for you it was only a squirrel.");
        Terminal.WriteLine("type next to continue");
    }

    void StartWalkingContinues()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("You start walking again. now you take out your earphones and listen to");
        Terminal.WriteLine("music as you walk. It feels safer that way.");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
