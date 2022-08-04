using GuitarAndBass.Note.Models;
using GuitarAndBass.StringInstruments.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarAndBass.StringInstruments
{
    public interface IStrings
    {
        List<FretModel> GenerateNotesForAllFrets(int NumOfStrings);
    }
}
