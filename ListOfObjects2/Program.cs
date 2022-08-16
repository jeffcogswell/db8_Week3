
//
// Section 1: Create and populate the list of songs
//

List<Song> playlist = new List<Song>();

// We don't need to keep making a new variable after we put the object in the list.
Song song1 = new Song("The Beatles", "I Want to Hold Your Hand", "Rock", 1964);
playlist.Add(song1);

// Let's just re-use the song1 variable.
song1 = new Song("Pink Floyd", "Comfortably Numb", "Progressive", 1979);
playlist.Add(song1);

song1 = new Song("Britney Spears", "Toxic", "Pop", 2003);
playlist.Add(song1);

// Jeff's favorite approach
// In fact, we don't need a variable at all. We just the create the object,
// and hand its address right over to the List's Add method.
playlist.Add(new Song("Dave Brubeck", "Take 5", "Jazz", 1959));

//
// Section 2: Print out the titles
//

Console.WriteLine("Here is your playlist:");
foreach (Song next in playlist)
{
	Console.WriteLine(next.Title);
}


//
// Section 3: Ask the user for a song and print out the details
//

Console.Write("Which song title do you want more info on: ");
string mysong = Console.ReadLine();

Song found = FindSong(playlist, mysong);
if (found == null)
{
	Console.WriteLine("Sorry, we don't have that song.");
}
else
{
	Console.WriteLine(found);
}


//
// Section 4: A "helper method" that searches the list by title.
//            Side note: We need to pass the list in. Fact of life...
//

static Song FindSong(List<Song> thelist, string thetitle)
{
	foreach (Song next in thelist)
	{
		if (next.Title.ToLower() == thetitle.ToLower())
		{
			return next;
		}
	}
	return null;
}

class Song
{
	public string Artist;
	public string Title;
	public string Genre;
	public int Year;

	public Song(string _Artist, string _Title, string _Genre, int _Year)
	{
		Artist = _Artist;
		Title = _Title;
		Genre = _Genre;
		Year = _Year;
	}

	public override string ToString()
	{
		return $"\"{Title}\" by {Artist} from {Year} ({Genre})";
	}
}
