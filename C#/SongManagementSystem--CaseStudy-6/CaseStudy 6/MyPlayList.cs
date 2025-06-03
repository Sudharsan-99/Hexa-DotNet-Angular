using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy_6
{
    public class MyPlayList : IPlaylist
    {
       
        public static List<Song> myPlayList = new List<Song>();

        // Capacity property
        private int capacity;

        // Constructor
        public MyPlayList()
        {
            capacity = 20; 
        }

        // Add a song to the playlist
        public void Add(Song song)
        {
            if (myPlayList.Count >= capacity)
            {
                Console.WriteLine("Cannot add more than 20 songs to the playlist.");
                return;
            }

            myPlayList.Add(song);
            Console.WriteLine($"Song '{song.SongName}' added to the playlist.");
        }

        // Remove a song by ID
        public void Remove(int songId)
        {
            for (int i = 0; i < myPlayList.Count; i++)
            {
                if (myPlayList[i].SongId == songId)
                {
                    myPlayList.RemoveAt(i);
                    break;
                }
            }
        }


        // Get song by ID
        public Song GetSongById(int songId)
        {
            foreach (var song in myPlayList)
            {
                if (song.SongId == songId)
                {
                    return song;
                }
            }
            return null; // If no song found with the given ID
        }


        // Get song by Name
        public Song GetSongByName(string songName)
        {
            foreach (var song in myPlayList)
            {
                if (song.SongName.ToLower() == songName.ToLower())
                {
                    return song;
                }
            }
            return null;
        }


        // Get all songs
        public List<Song> GetAllSongs()
        {
            return new List<Song>(myPlayList);
        }
    }
}
