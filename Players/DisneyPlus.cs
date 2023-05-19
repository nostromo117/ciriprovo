using Player;
using Player.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Players
{
    public class DisneyPlus : PlayerBase
    {
        public DisneyPlus(IMovie movieToPlay) : base(movieToPlay)
        {
        }

        public override bool CanPlay(IMovie movieToPlay)
        {
            return movieToPlay.Title.Contains("alien", StringComparison.OrdinalIgnoreCase);
        }

        public override void Play()
        {
            Console.WriteLine($"flusso video da {nameof(DisneyPlus)}");
        }
    }
}
