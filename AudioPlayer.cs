using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

public class AudioPlayer
{
    public static void PlayGreeting()
    {
        try
        {
            SoundPlayer player = new SoundPlayer("greeting.wav");
            player.PlaySync();
        }
        catch
        {
            Console.WriteLine("Audio could not be played.");
        }
    }
}
