using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

    internal class Voice
    {
        public static void PlayAudio()
        {
            try
            { 
                string audioPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "voice_audio.wav");

                
                if (File.Exists(audioPath))
                {
                    SoundPlayer player = new SoundPlayer(audioPath);
                    player.PlaySync();
                }
                else
                {
                    Console.WriteLine($"[Voice file not found at: {audioPath}]");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[Could not play audio: {ex.Message}]");
            }
        }
    }
}
        }
    }
}
