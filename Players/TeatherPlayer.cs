using Player;
using Player.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Players
{
    public class TeatherPlayer : PlayerBase
    {
        public TeatherPlayer(IMovie movieToPlay) : base(movieToPlay)
        {
        }

        public override bool CanPlay(IMovie movieToPlay)
        {
            return false;
        }

        public override void Play()
        {
            Console.WriteLine($"flusso video da {nameof(TeatherPlayer)}");
        }
    }
}
