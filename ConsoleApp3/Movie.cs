using Player.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Movie : IMovie
    {
		private string? _title;
		private MovieType MovieType;
		public MovieType Genere
		{
			get { return MovieType; }
			set { MovieType = value; }
		}
		//private Nullable<String> _name;
		public string? Title
		{
			get { return _title; }
			set { _title = value; }
		}
		public void Play()
		{
			Console.WriteLine($"sto riproducendo {this.Title}");
		}
	}
}
