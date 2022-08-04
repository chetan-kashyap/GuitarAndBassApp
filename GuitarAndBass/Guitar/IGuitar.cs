using GuitarAndBass.Note.Models;
using GuitarAndBass.StringInstruments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarAndBass.Guitar
{
    interface IGuitar
    {
        NoteModel GetNotePlayed(int FretPosition, int StringPlayed);
        bool IsValidGuitar(int FretPosition, int StringPlayed);
    }
}
