using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace CybersecurityChatbot
{
    public class Audio
    {
        public static void Player()
        {
            // 🎵 Play Luna's voice greeting
            SoundPlayer player = new SoundPlayer("C:\\Users\\lab_services_student\\Downloads\\Luna_Chatbot.wav");
            try
            {
                player.PlaySync();
            }
            catch (Exception ex)
            {
                Console.WriteLine("⚠️ Couldn't play audio: " + ex.Message);
            }
        }
    }
}
