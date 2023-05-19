using Player;
using Player.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Players
{
    public class PrimePlateyer : PlayerBase
    {
        public PrimePlateyer(IMovie movieToPlay) : base(movieToPlay)
        {
        }

        public override bool CanPlay(IMovie movieToPlay)
        {
            return false;
        }

        public override void Play()
        {
            //TODO non dimenticare di proiettare il film!!!!
            Console.WriteLine($"flusso video da {nameof(PrimePlateyer)}");

        }
    }
}
