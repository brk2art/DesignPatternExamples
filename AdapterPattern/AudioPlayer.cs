using System;

namespace AdapterPattern
{
    public class AudioPlayer : MediaPlayer
    {
        MediaAdapter mediaAdapter;

        public void play(string audioType, string fileName)
        {
            if (audioType.Equals("mp3"))
            {
                Console.WriteLine("Playing mp3 file. Name : " + fileName);
            }
            else if(audioType.Equals("vlc") || audioType.Equals("mp4"))
            {
                mediaAdapter = new MediaAdapter(audioType);
                mediaAdapter.play(audioType, fileName);
            }
            else
            {
                Console.WriteLine("Invalid media. " + audioType + " format not supported");
            }
        }
    }
}
