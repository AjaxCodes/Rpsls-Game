using System;
using System.Collections.Generic;
using System.Text;

namespace gamerpsls
{
    public class Game
    {
        // Member Variables
        Player player1;
        Player player2;

       
         public Game()
         {
           //player1 = new Player();
           //player2 = new Human();
           //player2 = new Player(Human, Computer); ** ask michael about this
           
            //player1.Choosegesture();
           //player2.ChooseGesture();           // Errors are till you define in other classes

         }
        
        public void RunGame()
        {
            //Display Rules method call
            //CreatePlayers();
            //Player objects call ChooseGesture()
            //CompareGestures() method gets called
        }
        //method responsible for creating players
        public void CreatePlayers()
        {
            Console.WriteLine("choose game mode");
            Console.WriteLine("1 for human v ai");
            Console.WriteLine("2 for human v human");

            string userInput = Console.ReadLine();

            if (userInput == "1")
            {
                player1 = new Human();
                player2 = new Computer();


            }
            else if(userInput == "2")
            {

                player1 = new Human();
                player2 = new Human();

            }
        }
        //compare gestures method
        public void CompareGestures()
        {
            if (player1.gesture == "rock")
            {
                //player1 > ChooseGesture "Scissors", "Lizard";
                if (player2.gesture == "scissors" || player2.gesture == "lizard")
                {
                    player1.score++;
                }
            }
            else if (player2.gesture == "rock")
            {
                //Re do round
            }
            else if (player1.gesture == "paper")
            {
                if (player2.gesture == "rock" || player2.gesture == "spock")
                {
                    player1.score++;
                }
            }   else if (player2.gesture == "paper") 
            {
                //Re do round
            }
            else if (player1.gesture == "scissors")
            {
                if (player2.gesture == "paper" || player2.gesture == "lizard")
                {
                    player1.score++;
                }
            }
            else if (player2.gesture == "scissors")
            {
                //Re do round
            }
            else if (player1.gesture == "lizard")
            {
                if (player2.gesture == "spock" || player2.gesture == "paper")
                {
                    player1.score++;
                }
            }
            else if (player2.gesture == "lizard")
            {
                //Re do round
            }
            else if (player1.gesture == "spock")
            {
                if (player2.gesture == "rock" || player2.gesture == "scissors")
                {
                    player1.score++;
                }
            }
            else if (player2.gesture == "spock")
            {
               // player1.player2.reroll; 
            }






        }


        public void DisplayRules() 
        {
            Console.WriteLine("The rules are");

            

            //if (rock)
            //{
                 // > Scissors, lizard

            //}
            //else if (paper)
            //{
                    // > rock, spock
            //}
            //else if (scissors)
            //{
                    // > paper, lizard
            //}
            //else if (lizard)
            //{
                    // >spock , paper
            //}
            //else if (p1 = rock, p2 = rock)
            //{
                    // tie, choose again
            //}
            //else if (p1 = paper, p2 = paper)
            //{
                    // tie, choose again
            //}//else if (p1 = scissors, p2 = scissors)
            //{
                    // tie, choose again
            //}//else if (p1 = lizard, p2 = lizard)
            //{
                    // tie, choose again
            //}//else if (p1 = spock, p2 = spock)
            //{
                    // tie, choose again
            //}

        }





        // Constructor

        // Member Method
    }
}
