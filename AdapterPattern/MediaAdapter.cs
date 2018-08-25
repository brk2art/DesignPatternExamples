namespace AdapterPattern
{
    public class MediaAdapter : MediaPlayer
    {
        AdvancedMediaPlayer advancedMusicPlayer;

        public MediaAdapter(string audioType)
        {
            if (audioType.Equals("vlc"))
            {
                advancedMusicPlayer = new VlcPlayer();
            }
            else
            {
                advancedMusicPlayer = new Mp4Player();
            }
        }

        public void play(string audioType, string fileName)
        {
            if (audioType.Equals("vlc"))
            {
                advancedMusicPlayer.playVlc(fileName);
            }
            else if (audioType.Equals("mp4"))
            {
                advancedMusicPlayer.playMp4(fileName);
            }
        }
    }
}
