using System.Collections.Generic;

namespace MusicSweetMusic.Entities
{
    public class Song
    {
        public Song(string name, int tempo)
        {
            Name = name;
            Tempo = tempo;
            Notes = new List<Note>();
        }

        public string Name { get; set; }

        public int Tempo { get; set; }

        public List<Note> Notes { get; set; }
    }
}