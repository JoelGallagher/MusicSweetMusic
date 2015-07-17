using MusicSweetMusic.LookUps;
using System;
using System.Threading;

namespace MusicSweetMusic.Entities
{
    public class Player
    {
        private double wholeNoteMilliseconds;
        private double halfNoteMilliseconds;
        private double quarterNoteMilliseconds;
        private double eigthNoteMilliseconds;
        private double sixteenthNoteMilliseconds;

        public void Play(Song song)
        {
            // do the calcs once per song
            PrepNoteLengths(song.Tempo);

            foreach (var note in song.Notes)
            {
                if (note.Frequency == NoteFrequencies.Rest)
                {
                    Thread.Sleep((int)getDuration(note.Length));
                }
                else
                {
                    Console.Beep(note.Frequency, (int)getDuration(note.Length));
                }
            }
        }

        private double getDuration(Enums.NoteLength length)
        {
            switch (length)
            {
                case Enums.NoteLength.WholeNote:
                    return wholeNoteMilliseconds;

                case Enums.NoteLength.HalfNote:
                    return halfNoteMilliseconds;

                case Enums.NoteLength.QuarterNote:
                    return quarterNoteMilliseconds;

                case Enums.NoteLength.EightNote:
                    return eigthNoteMilliseconds;

                case Enums.NoteLength.SixteenthNote:
                    return sixteenthNoteMilliseconds;

                default:
                    return 0;
            }
        }

        private void PrepNoteLengths(int tempo)
        {
            quarterNoteMilliseconds = (60 / Convert.ToDouble(tempo)) * 1000;

            wholeNoteMilliseconds = quarterNoteMilliseconds * 4;
            halfNoteMilliseconds = quarterNoteMilliseconds * 2;
            eigthNoteMilliseconds = quarterNoteMilliseconds / 2;
            sixteenthNoteMilliseconds = quarterNoteMilliseconds / 4;
        }
    }
}