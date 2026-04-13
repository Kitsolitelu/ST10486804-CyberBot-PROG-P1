using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace CyberBot_PROG_Prac1
{
    internal class Voice
    {
        public static void PlayAudio()
        {
            try
            {
                // This creates a path relative to where the app is actually running
                string audioPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "C:\\Users\\mosal\\source\\repos\\CyberBot PROG Prac1\\CyberBot PROG Prac1\\voice_audio.wav");

                if (File.Exists(audioPath)) // Use the dynamic path here
                {
                    SoundPlayer player = new SoundPlayer(audioPath);
                    player.PlaySync();
                }
                else
                {
                    // Helpful for debugging
                    Console.WriteLine($"[Voice greeting file not found at: {audioPath}]");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[Could not play audio: {ex.Message}]");
            }
        }
    }
}
