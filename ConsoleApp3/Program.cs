// See https://aka.ms/new-console-template for more information

using ConsoleApp3;
using PlayerMager;

Console.WriteLine("Hello Elisa");

var movie = new Movie { Title = "Alien", Genere = MovieType.Horror };
var playerMager = new Nirvana(movie);

Console.WriteLine("premi per visualizzare i player disponibili");
Console.ReadLine();

foreach (var player in playerMager.GetPlayers())
{  
    if(player.CanPlay(movie))
    {
        Console.WriteLine($"vuoi riprodurre {movie.Title} su {player}");
        var userChoice = Console.ReadLine();
        if (userChoice == "S")
        {
            movie.Play();
        }
        Console.WriteLine("ci spiace che non vuoi vedere i film");
        Console.WriteLine("premi un tasto per continuare");
        Console.ReadLine();
    }
    Console.WriteLine($"titolo non trovato su {player}");
    Console.ReadLine();
}

Console.ReadLine();