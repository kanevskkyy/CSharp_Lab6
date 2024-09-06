using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
        public class InvalidSongException : Exception
        {
            public InvalidSongException(string message = "Invalid song.") : base(message) { }
        }

        public class InvalidArtistNameException : InvalidSongException
        {
            public InvalidArtistNameException() : base("Artist name should be between 3 and 20 symbols.") { }
        }

        public class InvalidSongNameException : InvalidSongException
        {
            public InvalidSongNameException() : base("Song name should be between 3 and 30 symbols.") { }
        }

        public class InvalidSongLengthException : InvalidSongException
        {
            public InvalidSongLengthException()
                : base("Invalid song length.")
            { }
        }

        public class InvalidSongMinutesException : InvalidSongException
        {
            public InvalidSongMinutesException() : base("Song minutes should be between 0 and 14.")
            {
            }
        }

        public class InvalidSongSecondsException : InvalidSongException
        {
            public InvalidSongSecondsException() : base("Song seconds should be between 0 and 59.") { }
        }
}
