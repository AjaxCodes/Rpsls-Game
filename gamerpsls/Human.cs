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
           // gestures = new List<string>();  ???
            
            void PopulateGestures()
            {
                gestures = new List<string>();

                this.gestures.Add("Rock");
                this.gestures.Add("Paper");
                this.gestures.Add("Scissors");
                this.gestures.Add("Lizzard");
                this.gestures.Add("Spock");
            }     //Add gestures need conversion to INT

        }
        public override void ChooseGesture()
        {
            public int RandomNumber(0,4);
            {
                Random random = new Random(0); /// ask michael
                return Random.Next(0, 4);

            }
        }
    }
}
