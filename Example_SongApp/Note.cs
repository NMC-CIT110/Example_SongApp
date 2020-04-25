using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_SongApp
{
    /// <summary>
    /// simple class to hold the name and length of a note used in a song
    /// could also be implemented as a struct
    /// </summary>
    class SongNote
    {
        private NoteName _name;
        private NoteLength _length;
                     
        public NoteName Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public NoteLength Length
        {
            get { return _length; }
            set { _length = value; }
        }

        public SongNote()
        {

        }

        public SongNote(NoteName name, NoteLength length)
        {
            _name = name;
            _length = length;
        }
    }
}
