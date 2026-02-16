using System;

class Song
{
    public string title;
    public string artist;
    public double duration;
    public Song(string title, string artist, double duration)
    {
        this.title = title;
        this.artist = artist;
        this.duration = duration;
    }

    public void DisplaySong()
    {
        Console.WriteLine($"{title, -20}{artist, -15}{duration, 6:F2}");
    }

    static void Main()
    {
        Console.Write("Songs to add: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Song[] playlist = new Song[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\nSong #{i + 1}");

            Console.Write("Title: ");
            string title = Console.ReadLine();
            
            if (string.IsNullOrEmpty(title))
            {
                title = "Unknown";
            }
            Console.Write("Artist: ");
            string artist = Console.ReadLine();

            if (string.IsNullOrEmpty(artist))
            {
                artist = "Unknown";
            }

            Console.Write("Duration (minutes): ");
            string durationInput = Console.ReadLine();
            double duration;

            if (string.IsNullOrEmpty(durationInput))
            {
                duration = 0;
            }
            else
            {
                duration = double.Parse(durationInput);
            }


       
            playlist[i] = new Song(title, artist, duration); 
       
        }

        Console.WriteLine("\n=== || MY PLAYLIST || ===");
        Console.WriteLine($"{"Title", -20}{"Artist", -16}{"Time", 6}");
        Console.WriteLine("---------------------------------------------");

        double totalDuration = 0;

        foreach (Song song in playlist)
        {
            song.DisplaySong();
            totalDuration += song.duration;
        }

        double averageDuration = totalDuration / n;

        Console.WriteLine($"\nTotal Duration: {totalDuration:F2} mins");
        Console.WriteLine($"Average Duration: {averageDuration:F2} mins");
    }
}
