using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace gamerpsls
{
    public class Human : Player
    {
        public Human()
        {
           
        }
       
        public override void ChooseGesture()
        {
            Console.WriteLine("enter the number for the Gesture you would like to play, \n " +
                " 0 = rock, 1 - Paper, 2 =Scissors, 3 = lizard, 4 = spock. \n "+
                "only enter 0 , 1 , 2 , 3 , 4 , ");

            string userInput = Console.ReadLine(); // case sensitive in directions

            switch (userInput)
            {
                case "0":
                    gesture = "rock";
                    break;
                case "1":
                    gesture = "paper";
                    break;
                case "2":
                    gesture = "scissors";
                    break;
                case "3":
                    gesture = "lizard";
                    break;
                case "4":
                    gesture = "spock";
                    break;
                default:
                    gesture = "No Gesture found";
                    break;
            }
        }
        
    }
}
