using GuitarAndBass.StringInstruments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarAndBass.Note.Models
{
    public interface INoteRepo: IStrings
    {
        List<NoteModel> GetAllNotes();
        NoteModel GetNotePlayed(int FretPosition, int StringPlayed, int totalNumOfStrings);
    }
}
