using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace gamerpsls
{
    public abstract class Player
    {
        public string gesture;
        public string name;
        public int score;
        public List<string> gestures; 
        public Player() 
        {
          PopulateGestures();
        }
        public abstract void ChooseGesture();
        public void PopulateGestures() 
        {
            gestures = new List<string>();
            this.gestures.Add("Rock");
            this.gestures.Add("Paper");
            this.gestures.Add("Scissors");
            this.gestures.Add("Lizzard");
            this.gestures.Add("Spock");
        }
    }
}
