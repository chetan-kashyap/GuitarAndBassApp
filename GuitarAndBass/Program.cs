using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuitarAndBass.Guitar;
using GuitarAndBass.Note.Models;
using GuitarAndBass.StringInstruments;

namespace GuitarAndBass
{
    class Program
    {
        static void Main(string[] args)
        {
            StringModel instrumentInput = new StringModel();

            Console.WriteLine("enter the fret position");
            instrumentInput.FretPosition = int.Parse(Console.ReadLine());

            Console.WriteLine("enter the string played");
            instrumentInput.StringPlayed = int.Parse(Console.ReadLine());

            Console.WriteLine("enter the total num of strings");
            int totalNumOfStrings = int.Parse(Console.ReadLine());

            MockNoteRepo repo = new MockNoteRepo();

            if (totalNumOfStrings == 6)
            {
                GuitarAndBass.Guitar.Guitar instrument = new GuitarAndBass.Guitar.Guitar(repo);
                if (instrument.IsValidGuitar(instrumentInput.FretPosition, instrumentInput.StringPlayed))
                {
                    NoteModel notePlayed = instrument.GetNotePlayed(instrumentInput.FretPosition, instrumentInput.StringPlayed);
                    Console.WriteLine("The note you've played is" + notePlayed.Note);
                }
                else
                {
                    Console.WriteLine("Please enter valid inputs for Guitar. Fret position should range from 1 to 2, String played must range from 1 to 6");
                }
            }
            else if (totalNumOfStrings == 4)
            {
                GuitarAndBass.Bass.Bass instrument = new GuitarAndBass.Bass.Bass(repo);
                if (instrument.IsValidBass(instrumentInput.FretPosition, instrumentInput.StringPlayed))
                {
                    NoteModel notePlayed = instrument.GetNotePlayed(instrumentInput.FretPosition, instrumentInput.StringPlayed);
                    Console.WriteLine("The note you've played is" + notePlayed.Note);
                }
                else
                {
                    Console.WriteLine("Please enter valid inputs for Bass. Fret position should range from 1 to 3, String played must range from 1 to 4");
                }
            }
            else
            {
                Console.WriteLine("please enter the valid number of strings");
            }
            Console.Read();
        }
    }
}
