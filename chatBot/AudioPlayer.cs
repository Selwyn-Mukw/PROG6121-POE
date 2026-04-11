using System;
using System.Collections.Generic;
using System.Media;
using System.Text;

namespace chatBot
{
    
        // create a class which will play an audio file when the user starts the program
        public class AudioPlayer

        {
            public void PlayAudio(string filePath)
            {
                // Create audio which will be played when the user starts the program
                SoundPlayer player = new SoundPlayer(filePath);
                player.Play();
                
            }
        }
 }

