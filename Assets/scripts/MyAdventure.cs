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
        Help,
        Help2,
        IgnoreHim,
        End,
    }

    private States currentState = States.start;
    
    // Start is called before the first frame update
    

    

    void OnUserInput(string input)
    {
        print(currentState);
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
                currentState = States.turnAround;
                StartTurnAround();
            }else if (input == "no")
            {
                currentState = States.walkingContinues;
                StartWalkingContinues();
            }
        }
        
        if (currentState == States.turnAround)
        {
            if (input == ("next"))
            {
                currentState = States.walkingContinues;
                StartWalkingContinues();
            }
        }

        if (currentState == States.walkingContinues)
        {
            if (input == "next")
            {
                currentState = States.Help;
                StartHelp();
            }
        }

        if (currentState == States.Help)
        {
            if (input == "yes")
            {
                currentState = States.Help2;
                StartHelp2();
            } else if (input == "no")
            {
                currentState = States.IgnoreHim;
                StartIgnoreHim();
            }
        }

        if (currentState == States.Help2)
        {
            if (input == "next")
            {
                currentState = States.End;
                StartEnd();
            }
        }

        if (currentState == States.IgnoreHim)
        {
            if (input == "next")
            {
                currentState = States.End;
                StartEnd();
            }
        }

        if (currentState == States.End)
        {
            if (input == "home")
            {
                currentState = States.start ;
                ShowMainMenu();
            }
        }

    }
    
    void Start()
    {
        print("Hello World");
        ShowMainMenu();
    }
    
    void ShowMainMenu()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Welcome to Self Disaster!");
        Terminal.WriteLine("This story can happen to each and everyone of us.");
        Terminal.WriteLine("So be aware of your surroundings after you finish this game.");
        Terminal.WriteLine("");
        Terminal.WriteLine("Type 'start' to start the game.");
        Terminal.WriteLine("");
    } 

    void StartIntro()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("You just finished work and are on your way home. You know you have towalk a shady route but its the only fast way to get to your apartment.");
        Terminal.WriteLine("As you start walking, you feel a presence behind you. So, you stop");
        Terminal.WriteLine("walking.");
        Terminal.WriteLine("");
        Terminal.WriteLine("Wanna see what's behind you?");
        Terminal.WriteLine("Type 'yes' to see what is there,");
        Terminal.WriteLine("Type 'no' to continue walking...");
        Terminal.WriteLine("");
    }

    void StartTurnAround()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("You turn around, but there is no one.");
        Terminal.WriteLine("You see ruffling in the bushes on the left, but luckily for you it");
        Terminal.WriteLine("was only a squirrel.");
        Terminal.WriteLine("");
        Terminal.WriteLine("type 'next' to continue");
        Terminal.WriteLine("");
    }

    void StartWalkingContinues()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("You start walking again. now you take out your earphones and listen");
        Terminal.WriteLine("to music as you walk. It feels safer that way. But then, you feel");
        Terminal.WriteLine("someone tapping your shoulder and turn around to see who it is...");
        Terminal.WriteLine("");
        Terminal.WriteLine("Type 'next' to continue...");
        Terminal.WriteLine("");
    }

    void StartHelp()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("It is an old man asking you to help him get home.");
        Terminal.WriteLine("should you help him?");
        Terminal.WriteLine("");
        Terminal.WriteLine("Type 'yes' to help");
        Terminal.WriteLine("Type 'no' to ignore him");
        Terminal.WriteLine("");
    }

    void StartHelp2()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("You're contemplating whether to help him because it is very late and mama told you not to talk to anyone when its");
        Terminal.WriteLine("really dark. You feel bad for him so");
        Terminal.WriteLine("you help him get home.");
        Terminal.WriteLine("");
        Terminal.WriteLine("As soon as you said yes, he turned into the shadow monster. He grabbed you");
        Terminal.WriteLine("by the arm and hid you inside of him. You scream and scream but no one will");
        Terminal.WriteLine("ever hear you. Till this day, you were never found.");
        Terminal.WriteLine("Type 'next'...");
    }

    void StartIgnoreHim()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("You're contemplating whether to help him because it is very late and mama told you not to talk to anyone when its");
        Terminal.WriteLine("really dark. He also seems really edgy so you prefer not to help him. So you");
        Terminal.WriteLine("walk on. You turn around to see if the man is still there and as you look for");
        Terminal.WriteLine("him, he turned in to the shadow monster and ate another woman alive. You");
        Terminal.WriteLine("quickly run home before he comes to get you next. Fortunately for you, you");
        Terminal.WriteLine("made it home safe.");
        Terminal.WriteLine("Type 'next'...");

    }

    void StartEnd()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("THE END.");
        Terminal.WriteLine("Type 'home' to go to start screen...");
        Terminal.WriteLine("");
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
