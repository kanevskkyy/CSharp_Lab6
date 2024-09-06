using System;
using task_3;

class Task
{
    static void Main()
    {
        Console.Write("Enter amount of songs = ");
        int NumberSongs = int.Parse(Console.ReadLine());
        Line();
        List<Songs> songs = new List<Songs>();

        int totalMinutes = 0, totalSeconds = 0; 
        for(int i = 0; i < NumberSongs; i++)
        {
            try
            {
                Console.Write($"Information of {i + 1} song = ");
                string[] information_of_song = Console.ReadLine().Split(";");
                Songs temp_song = new Songs(information_of_song[0], information_of_song[1], information_of_song[2]);
                songs.Add(temp_song);

                string[] time = information_of_song[2].Split(":");
                totalMinutes += int.Parse(time[0]);
                totalSeconds += int.Parse(time[1]);

                Console.WriteLine("Songs added!");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Line();
        }
        totalMinutes += totalSeconds / 60;
        totalSeconds %= 60;
        int totalHours = totalMinutes / 60;
        totalMinutes %= 60;

        Console.WriteLine($"Songs added: {songs.Count}");
        Console.WriteLine($"Playlist length: {totalHours}h {totalMinutes}m {totalSeconds}s");
    }
    public static void Line()
    {
        Console.WriteLine("=======================================");
    }
}
