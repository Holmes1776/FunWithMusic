using System;
namespace Songs_Music
{
    class Program
    {
        enum Genre
        {
            Jazz,
            Rock,
            Swing,
            Orchestral,
            Country
        }
        struct Music
        {
            private string Title;
            private string Artist;
            private string Album;
            private string Length;
            private Genre? Genre;

            public Music(string title, string artist, string album,string length, Genre genre)
            {
                Title = title;
                Artist = artist;
                Album = album;
                Length = length;
                Genre = genre;
            }
            public string Display()
            {
                return "Title: " + Title + "\nArtist: " + Artist +
                    "\nAlbum: " + Album + "\nLength:" + Length + "\nGenre:" + Genre;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("What is the title of your favorite Song?");
            string tempTitle = Console.ReadLine();
            Console.WriteLine("Who wrote it?");
            string tempArtist = Console.ReadLine();
            Console.WriteLine("What album is it from?");
            string tempAlbum = Console.ReadLine();
            Console.WriteLine("What is the length of the song?");
            string tempLength = Console.ReadLine();
            Console.WriteLine("What kind of music is it? i.e genre.");
            Console.WriteLine("J - Jazz\nR - Rock\nS - Swing\nO - Orchestral\nC - Country");
            Genre tempGenre = Genre.Jazz;
            char g = char.Parse(Console.ReadLine());
            switch (g)
            {
                case 'J':
                    tempGenre = Genre.Jazz;
                    break;
                case 'R':
                    tempGenre = Genre.Rock;
                    break;
                case 'S':
                    tempGenre = Genre.Swing;
                    break;
                case 'O':
                    tempGenre = Genre.Orchestral;
                    break;
                case 'C':
                    tempGenre = Genre.Country;
                    break;
            }
            Music song = new Music(tempTitle, tempArtist, tempAlbum, tempLength, tempGenre);
            Console.WriteLine($"{song.Display()}");
        }
    }
}
