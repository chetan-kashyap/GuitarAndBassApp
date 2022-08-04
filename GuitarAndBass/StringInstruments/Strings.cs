using GuitarAndBass.Note.Models;
using GuitarAndBass.StringInstruments.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarAndBass.StringInstruments
{
    class Strings : IStrings
    {
        private readonly INoteRepo _repo;

        public Strings(INoteRepo repo)
        {
            this._repo = repo;
        }
        public List<FretModel> GenerateNotesForAllFrets(int NumOfStrings)
        {
            return _repo.GenerateNotesForAllFrets(NumOfStrings);
        }

    }
}
