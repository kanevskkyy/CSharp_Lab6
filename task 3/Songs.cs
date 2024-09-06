using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
    internal class Songs
    {
        public string ArtistName { get; set; }
        public string SongName { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        public Songs(string artistName, string SongName, string Length)
        {
            ValidateArtistName(artistName);
            ValidateSongName(SongName);
            ValidateSongLength(Length);

            ArtistName = artistName;
            this.SongName = SongName;

            string[] time = Length.Split(':');
            Minutes = int.Parse(time[0]);
            Seconds = int.Parse(time[1]);
        }


        private void ValidateArtistName(string artistName)
        {
            if (artistName.Length < 3 || artistName.Length > 20) throw new InvalidArtistNameException();
        }

        private void ValidateSongName(string SongName)
        {
            if (SongName.Length < 3 || SongName.Length > 30) throw new InvalidSongNameException();
        }

        private void ValidateSongLength(string Length)
        {
            if (Length.Length < 2) throw new InvalidSongLengthException();
            
            string[] time = Length.Split(':');
            int minutes = int.Parse(time[0]);
            int seconds = int.Parse(time[1]);

            if (minutes < 0 || minutes > 14) throw new InvalidSongMinutesException();
            if (seconds < 0 || seconds > 59) throw new InvalidSongSecondsException();
        }

    }
}
