using MusicSweetMusic.Entities;
using MusicSweetMusic.Songs;
using System;

namespace MusicSweetMusic
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var player = new Player();
            var sweetChildOMine = SweetChildOMine.GetSong();

            player.Play(sweetChildOMine);

            Console.ReadKey();
        }
    }
}