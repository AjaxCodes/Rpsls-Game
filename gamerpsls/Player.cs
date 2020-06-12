using System;
using System.Collections.Generic;
using System.Text;

namespace gamerpsls
{
    public abstract class Player
    {
        //member variables (has a)
        public string gesture;
        public string name;
        public int score;
        public List<string> gestures;


        public Player() 
        {

            
            




        }
        public abstract void ChooseGesture();     //(virtual if child)
        








}
}
