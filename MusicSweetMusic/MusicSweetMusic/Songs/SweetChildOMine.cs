using MusicSweetMusic.Entities;
using MusicSweetMusic.LookUps;

namespace MusicSweetMusic.Songs
{
    public static class SweetChildOMine
    {
        public static Song GetSong()
        {
            var result = new Song("Sweet Child of Mine", 120);

            // bar 1 (D)
            scom_D(result);
            // bar 2 (D)
            scom_D(result);
            // bar 3 (E)
            scom_E(result);
            // bar 4 (D)
            scom_E(result);
            // bar 5 (G)
            scom_G(result);
            // bar 6 (G)
            scom_G(result);
            // bar 7 (D)
            scom_D(result);
            // bar 8 (D)
            scom_D(result);

            return result;
        }

        private static void scom_G(Song song)
        {
            song.Notes.Add(new Note(NoteFrequencies.G4, Enums.NoteLength.EightNote));
            song.Notes.Add(new Note(NoteFrequencies.D5, Enums.NoteLength.EightNote));
            song.Notes.Add(new Note(NoteFrequencies.A4, Enums.NoteLength.EightNote));
            song.Notes.Add(new Note(NoteFrequencies.G4, Enums.NoteLength.EightNote));
            song.Notes.Add(new Note(NoteFrequencies.G5, Enums.NoteLength.EightNote));
            song.Notes.Add(new Note(NoteFrequencies.A4, Enums.NoteLength.EightNote));
            song.Notes.Add(new Note(NoteFrequencies.Fs5_Gb5, Enums.NoteLength.EightNote));
            song.Notes.Add(new Note(NoteFrequencies.A4, Enums.NoteLength.EightNote));
        }

        private static void scom_E(Song song)
        {
            song.Notes.Add(new Note(NoteFrequencies.E4, Enums.NoteLength.EightNote));
            song.Notes.Add(new Note(NoteFrequencies.D5, Enums.NoteLength.EightNote));
            song.Notes.Add(new Note(NoteFrequencies.A4, Enums.NoteLength.EightNote));
            song.Notes.Add(new Note(NoteFrequencies.G4, Enums.NoteLength.EightNote));
            song.Notes.Add(new Note(NoteFrequencies.G5, Enums.NoteLength.EightNote));
            song.Notes.Add(new Note(NoteFrequencies.A4, Enums.NoteLength.EightNote));
            song.Notes.Add(new Note(NoteFrequencies.Fs5_Gb5, Enums.NoteLength.EightNote));
            song.Notes.Add(new Note(NoteFrequencies.A4, Enums.NoteLength.EightNote));
        }

        private static void scom_D(Song song)
        {
            song.Notes.Add(new Note(NoteFrequencies.D4, Enums.NoteLength.EightNote));
            song.Notes.Add(new Note(NoteFrequencies.D5, Enums.NoteLength.EightNote));
            song.Notes.Add(new Note(NoteFrequencies.A4, Enums.NoteLength.EightNote));
            song.Notes.Add(new Note(NoteFrequencies.G4, Enums.NoteLength.EightNote));
            song.Notes.Add(new Note(NoteFrequencies.G5, Enums.NoteLength.EightNote));
            song.Notes.Add(new Note(NoteFrequencies.A4, Enums.NoteLength.EightNote));
            song.Notes.Add(new Note(NoteFrequencies.Fs5_Gb5, Enums.NoteLength.EightNote));
            song.Notes.Add(new Note(NoteFrequencies.A4, Enums.NoteLength.EightNote));
        }
    }
}