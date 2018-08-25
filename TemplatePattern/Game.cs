namespace TemplatePattern
{
    public abstract class Game
    {
        public abstract void initialize();
        public abstract void startPlay();
        public abstract void endPlay();

        public void play()
        {
            //initialize the game
            initialize();

            //start game
            startPlay();

            //end game
            endPlay();
        }
    }
}
