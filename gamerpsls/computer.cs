using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace gamerpsls
{
    public class Computer : Player
    {
        public string gesture;
        public string name;
        public int score;
        int Rock;
        int scissors;
        int paper;
        int spock;
        int lizard;
           

        // Constructor
        public Computer()
        {   
            
            gestures = new List<string>();
            void PopulateGestures()   // human and computer should have this as well with out adding?
            {
                this.gestures.Add("Rock");
                this.gestures.Add("Paper");
                this.gestures.Add("Scissors");
                this.gestures.Add("Lizzard");
                this.gestures.Add("Spock");
            }
        }
        // Member Method

        public override void ChooseGesture()
        {
            int RandomNumber(0,4);
            {
                Random random = new Random(0);
                return Random.next (0, 4);
            
            }


        }


    }
}
