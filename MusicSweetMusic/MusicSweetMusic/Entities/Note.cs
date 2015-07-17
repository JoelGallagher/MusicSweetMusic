using MusicSweetMusic.LookUps;

namespace MusicSweetMusic.Entities
{
    public class Note
    {
        public Note(int frequency, Enums.NoteLength length)
        {
            Frequency = frequency;
            Length = length;
        }

        public int Frequency { get; set; }

        public Enums.NoteLength Length { get; set; }
    }
}