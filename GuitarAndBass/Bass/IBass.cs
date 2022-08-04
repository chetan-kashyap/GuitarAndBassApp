using GuitarAndBass.Note.Models;
using GuitarAndBass.StringInstruments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarAndBass.Bass
{
    interface IBass
    {
        NoteModel GetNotePlayed(int FretPosition, int StringPlayed);
        bool IsValidBass(int FretPosition, int StringPlayed);
    }
}
