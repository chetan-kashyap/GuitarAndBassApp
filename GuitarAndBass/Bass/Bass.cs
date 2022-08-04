using GuitarAndBass.Note.Models;
using GuitarAndBass.StringInstruments.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarAndBass.Bass
{
    class Bass : IBass
    {
        private readonly INoteRepo _repo;
        int totalNumOfStrings = 4;
        public Bass(INoteRepo repo)
        {
            this._repo = repo;
        }

        public NoteModel GetNotePlayed(int FretPosition, int StringPlayed)
        {
            return _repo.GetNotePlayed(FretPosition, StringPlayed, totalNumOfStrings);
        }

        public bool IsValidBass(int FretPosition, int StringPlayed)
        {
            return (FretPosition <= 0 || FretPosition > 3 || StringPlayed <= 0 || StringPlayed > 4) ? false : true;
        }

    }
}
