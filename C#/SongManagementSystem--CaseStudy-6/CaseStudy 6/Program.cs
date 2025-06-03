namespace CaseStudy_6
{
    class Program
    {
        static void Main(string[] args)
        {
            MyPlayList myPlayList = new MyPlayList();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\nEnter 1: To Add Song");
                Console.WriteLine("Enter 2: To Remove Song by Id");
                Console.WriteLine("Enter 3: Get Song By Id");
                Console.WriteLine("Enter 4: Get Song By Name");
                Console.WriteLine("Enter 5: Get All Songs from a myPlayList");
                Console.WriteLine("Enter 6: Exit");

                Console.Write("Enter your choice: ");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        // Add Song
                        Song newSong = new Song();

                        Console.Write("Enter Song Id (int): ");
                        newSong.SongId = int.Parse(Console.ReadLine());

                        Console.Write("Enter Song Name: ");
                        newSong.SongName = Console.ReadLine();

                        Console.Write("Enter Song Genre: ");
                        newSong.SongGenre = Console.ReadLine();

                        myPlayList.Add(newSong);
                        break;

                    case "2":
                        // Remove Song by Id
                        Console.Write("Enter Song Id to remove: ");
                        int removeId = int.Parse(Console.ReadLine());
                        myPlayList.Remove(removeId);
                        break;

                    case "3":
                        // Get Song by Id
                        Console.Write("Enter Song Id to search: ");
                        int searchId = int.Parse(Console.ReadLine());
                        Song songById = myPlayList.GetSongById(searchId);
                        if (songById != null)
                        {
                            Console.WriteLine($"Song Found - Id: {songById.SongId}, Name: {songById.SongName}, Genre: {songById.SongGenre}");
                        }
                        else
                        {
                            Console.WriteLine("Song not found.");
                        }
                        break;

                    case "4":
                        // Get Song by Name
                        Console.Write("Enter Song Name to search: ");
                        string searchName = Console.ReadLine();
                        Song songByName = myPlayList.GetSongByName(searchName);
                        if (songByName != null)
                        {
                            Console.WriteLine($"Song Found - Id: {songByName.SongId}, Name: {songByName.SongName}, Genre: {songByName.SongGenre}");
                        }
                        else
                        {
                            Console.WriteLine("Song not found.");
                        }
                        break;

                    case "5":
                        // Get All Songs
                        List<Song> allSongs = myPlayList.GetAllSongs();
                        if (allSongs.Count == 0)
                        {
                            Console.WriteLine("No songs in the myPlayList.");
                        }
                        else
                        {
                            Console.WriteLine("Songs in Playlist:");
                            foreach (var song in allSongs)
                            {
                                Console.WriteLine($"Id: {song.SongId}, Name: {song.SongName}, Genre: {song.SongGenre}");
                            }
                        }
                        break;

                    case "6":
                        exit = true;
                        Console.WriteLine("Exiting the program.");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }

}
