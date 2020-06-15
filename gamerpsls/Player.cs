using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace gamerpsls
{
    public abstract class Player
    {
        //member variables (has a)
        public string gesture;
        public string name;
        public int score;
        int Rock;
        string scissors;                            
        string paper;
        string spock;
        string lizard;
        int gestureNumber;
        public List<string> gestures; 
        public Player() // parent class
        {
            void PopulateGestures(string name, int gestureNumber) // ask michael
            {
                this.gestures.Add("Rock");
                this.gestures.Add("Paper");
                this.gestures.Add("Scissors");
                this.gestures.Add("Lizzard");
                this.gestures.Add("Spock"); // needs override method?
            }
        }
        public void ChooseGesture() 
        {
            Console.ReadLine();
        }     
        
        







    }
}
