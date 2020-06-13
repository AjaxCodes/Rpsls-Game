using System;
using System.Collections.Generic;
using System.Text;

namespace gamerpsls
{
    public class Computer : Player
    {
        // Member Variables**** do

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
            //Random class*** do
            
        }


    }
}
