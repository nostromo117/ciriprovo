using ConsoleApp3.Players;
using Player.Commons;
using Players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerMager
{
    public class Nirvana
    {
        List<IPlayer> players= new List<IPlayer>();
        public Nirvana(IMovie movieToPlay)
        {
            players.Add(new NetflixPlayer(movieToPlay));
            players.Add(new DisneyPlus(movieToPlay));
            players.Add(new PrimePlateyer(movieToPlay));
        }

        public List<IPlayer> GetPlayers()
        { 
            return  players;
        }

    }
}
