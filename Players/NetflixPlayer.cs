using Player;
using Player.Commons;
using System;


namespace Players
{
    public class NetflixPlayer : PlayerBase
    {
        public NetflixPlayer(IMovie movieToPlay) : base(movieToPlay)
        {
        }

        public override bool CanPlay(IMovie movieToPlay)
        {
            return false;
        }

        public override void Play()
        {
            //TODO fare qualcosa
            Console.WriteLine($"flusso video da {nameof(NetflixPlayer)}");
           movieToPlay.Play();
        }
    }
}
