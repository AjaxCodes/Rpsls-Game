using System;
using System.Collections.Generic;
using System.Text;

namespace gamerpsls
{
    public class Game
    {
        
        Player player1;
        Player player2;


        public Game()
        {


        }

        public void RunGame()
        {
            
            DisplayRules();
            CreatePlayers();
            player1.ChooseGesture();
            player2.ChooseGesture();
            CompareGestures();
        }
        
        public void CreatePlayers()
        {
            Console.WriteLine("choose game mode");
            Console.WriteLine("1 for human v computer");
            Console.ReadLine();
            Console.WriteLine("2 for human v human");
            Console.ReadLine();

            string userInput = Console.ReadLine();

            if (userInput == "1")
            {
                player1 = new Human();
                player2 = new Computer();


            }
            else if (userInput == "2")
            {

                player1 = new Human();
                player2 = new Human();

            }
        }

        public void CompareGestures()
        {
            if (player1.gesture == "rock")
            {

                if (player2.gesture == "scissors" || player2.gesture == "lizard")
                {
                    player1.score++;
                }
            }
            else if (player1.gesture == "paper")
            {
                if (player2.gesture == "rock" || player2.gesture == "spock")
                {
                    player1.score++;
                }
            }
            else if (player1.gesture == "scissors")
            {
                if (player2.gesture == "paper" || player2.gesture == "lizard")
                {
                    player1.score++;
                }
            }
            else if (player1.gesture == "lizard")
            {
                if (player2.gesture == "spock" || player2.gesture == "paper")
                {
                    player1.score++;
                }
            }
            else if (player1.gesture == "spock")
            {
                if (player2.gesture == "rock" || player2.gesture == "scissors")
                {
                    player1.score++;
                }
            }
            else if (player1.gesture == player2.gesture)
            {
                Console.WriteLine("Tie");
            }
            else
            {
                player2.score++;
            }
        }


        public void DisplayRules()
        {
            Console.WriteLine("The rules are");
            Console.WriteLine("Each player has a turn. \n" +
                "Player 1 then Player 2. \n" +
                "whichever players chosen gesture has a winning value will recieve a point. \n" +
                " The first player to score 2 points wins \n" +
                "gestures are as follows. " +
                "Rock = 0 . paper = 1  . scissors = 2 . lizard = 3. spock = 4. \n" +
                "0 Rock beats scisors and lizard \n" +
                "1 paper beats rock and spock \n "+
                "2 scissors beats paper and lizard \n" +
                "3 lizard beats spock and paper \n" +
                "4 spock beats rock and scissors");



        }



    }

        
}
