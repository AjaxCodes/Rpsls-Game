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
        string Scissors;                            
        string Paper;
        string Spock;
        string Lizard;
       
        public List<string> gestures; //? Override
        public Player() // parent class
        {
            void PopulateGestures()   // human and computer should have this as well with out adding?
            {
                this.gestures.Add("Rock");
                this.gestures.Add("Paper");
                this.gestures.Add("Scissors");
                this.gestures.Add("Lizzard");
                this.gestures.Add("Spock");
            }
        }
        public void ChooseGesture() // I think this is because its abstract 
        {
            Console.ReadLine();
        }     //(virtual if child)
        
        







    }
}
