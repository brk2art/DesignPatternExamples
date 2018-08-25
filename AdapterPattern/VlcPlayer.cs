using System;

namespace AdapterPattern
{
    public class VlcPlayer : AdvancedMediaPlayer
    {
        public void playMp4(string fileName)
        {
            
        }

        public void playVlc(string fileName)
        {
            Console.WriteLine("Playing Vlc file. Name: " + fileName);
        }
    }
}
