namespace MusicSpace
{
    interface IPlayable
    {
         public string Play();
    }
    class MusicPlayer:IPlayable
    {
        public string Play()
        {
            return "Playing in MusicPlayer";
        }
    }

    class VideoPlayer : IPlayable
    {
        public string Play()
        {
            return "Playing in VideoPlayer";
        }
    }
}