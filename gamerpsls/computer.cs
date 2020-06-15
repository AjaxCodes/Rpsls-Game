using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace gamerpsls
{
    public class Computer : Player
    {
        public Computer()
        {   
            
        }
        public override void ChooseGesture()
        {
            int randomNumber = RandomNumber(0, 4);
            gesture = gestures[randomNumber];
        }
        int RandomNumber(int min, int max)
        {   
            Random random = new Random();
            return random.Next(min, max); 
        }

    }
}
