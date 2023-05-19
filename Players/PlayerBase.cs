using Player.Commons;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player
{
    public abstract class PlayerBase : IPlayer
    {
        private int id;
        private string name;
        private string description;
        protected IMovie movieToPlay;

        public PlayerBase(IMovie movieToPlay)
        {
            this.movieToPlay = movieToPlay;
        }
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Title
        {
            get { return name; }
            set { name = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public abstract void Play();


        public abstract bool CanPlay(IMovie movieToPlay);
     

    }
}

