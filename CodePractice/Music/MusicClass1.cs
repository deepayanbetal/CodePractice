using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace CodePractice.Music
{
    internal class MusicClass1
    {
        public void playMusic()
        {
            while(true)
            {
                Console.WriteLine("Press enter");
                Console.ReadLine();
                SoundPlayer play = new SoundPlayer(@"C:\Users\deepa\OneDrive\Desktop\Music\mech-keyboard-02-102918.wav");
                play.Play();
            }
        }
    }
}
