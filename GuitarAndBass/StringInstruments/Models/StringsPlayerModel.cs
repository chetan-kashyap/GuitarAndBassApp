using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarAndBass.StringInstruments.Models
{
    class StringsPlayerModel : StringsModel
    {
        public int FretPosition { get; set; }
        public int StringPlayed { get; set; }
    }
}
