using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarAndBass.Note.Models
{
    public class MockNoteRepo : INoteRepo
    {

        public List<FretModel> GenerateNotesForAllFrets(int NumOfStrings)
        {
            var allNotes = GetAllNotes();
            int totalNumberOfFrets = (NumOfStrings == 6) ? 2 : 3;
            List<FretModel> frets = new List<FretModel>();

            for (int i = 0; i < totalNumberOfFrets; i++)
            {
                FretModel fret = new FretModel();
                fret.FretPosition = i + 1;
                fret.StringNumbers = new int[NumOfStrings];
                List<NoteModel> notesList = new List<NoteModel>();
                for (int j = 0; j < NumOfStrings; j++)
                {
                    notesList.Add(allNotes.Where(x => x.ID == ((5 * (j + 1)) + i) % 12).FirstOrDefault());
                    fret.StringNumbers[j] = j + 1;
                }
                fret.FretNotes = notesList;
                frets.Add(fret);
            }
            return frets;
        }

        public List<NoteModel> GetAllNotes()
        {
            List<NoteModel> allNotes = new List<NoteModel>() {
                new NoteModel() { ID = 1, Note = "C", Alias="C" },
                new NoteModel() { ID = 2, Note = "C#", Alias="Db" },
                new NoteModel() { ID = 3, Note = "D", Alias="D" },
                new NoteModel() { ID = 4, Note = "D#", Alias="Eb" },
                new NoteModel() { ID = 5, Note = "E", Alias="E" },
                new NoteModel() { ID = 6, Note = "F", Alias="F" },
                new NoteModel() { ID = 7, Note = "F#", Alias="Gb" },
                new NoteModel() { ID = 8, Note = "G", Alias="G" },
                new NoteModel() { ID = 9, Note = "G#", Alias="Ab" },
                new NoteModel() { ID = 10, Note = "A", Alias="A" },
                new NoteModel() { ID = 11, Note = "A#", Alias="Bb" },
                new NoteModel() { ID = 12, Note = "B", Alias="B" }
            };
            return allNotes;
        }

        public NoteModel GetNotePlayed(int FretPosition, int StringPlayed, int totalNumOfStrings)
        {
            List<FretModel> allFrets = GenerateNotesForAllFrets(totalNumOfStrings);
            FretModel fret = allFrets.Where(x => x.FretPosition == FretPosition).FirstOrDefault();
            return fret.FretNotes[StringPlayed - 1];
        }
    }
}
