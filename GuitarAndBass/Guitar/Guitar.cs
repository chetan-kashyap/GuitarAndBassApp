using GuitarAndBass.Note.Models;
using GuitarAndBass.StringInstruments;
using GuitarAndBass.StringInstruments.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarAndBass.Guitar
{
    public class Guitar
    {
        protected readonly INoteRepo _repo;
        int totalNumOfStrings = 6;
        public Guitar(INoteRepo repo)
        {
            _repo = repo;
        }

        public NoteModel GetNotePlayed(int FretPosition, int StringPlayed)
        {
            return _repo.GetNotePlayed(FretPosition, StringPlayed, totalNumOfStrings);
        }

        public bool IsValidGuitar(int FretPosition, int StringPlayed)
        {
            return (FretPosition <= 0 || FretPosition > 2 || StringPlayed <= 0 || StringPlayed > 6) ? false : true;
        }

    }
}
