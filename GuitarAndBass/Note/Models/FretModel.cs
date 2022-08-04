using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarAndBass.Note.Models
{
    public class FretModel
    {
        public int FretPosition { get; set; }
        public List<NoteModel> FretNotes { get; set; }
        public int[] StringNumbers { get; set; }
    }
}
