



var actors = new List<Actor> {
            new Actor { Name = "John Doe" },
            new Actor { Name = "Jane Smith" },
            new Actor { Name = "Alice Johnson" },
            new Actor { Name = "Bob Brown" },
            new Actor { Name = "Charlie Davis" },
            new Actor { Name = "Diana Prince" },
            new Actor { Name = "Ethan Hunt" },
            new Actor { Name = "Fiona Green" },
            new Actor { Name = "George White" },
            new Actor { Name = "Hannah Black" },
            new Actor { Name = "Ian Gray" },
            new Actor { Name = "Julia Blue" },
            new Actor { Name = "Kevin Red" },
            new Actor { Name = "Laura Yellow" },
            new Actor { Name = "Mike Orange" },
            new Actor { Name = "Nina Purple" },
            new Actor { Name = "Oscar Pink" },
            new Actor { Name = "Paula Cyan" },
            new Actor { Name = "Quinn Magenta" },
            new Actor { Name = "Rachel Silver" }
        };

var movies = new List<Movie> {
            new Movie { Title = "The Great Adventure", ReleaseYear = 2021, Actors = new List<Actor> { actors[0], actors[1], actors[2] } },
            new Movie { Title = "Mystery of the Lost City", ReleaseYear = 2020, Actors = new List<Actor> { actors[1], actors[3], actors[4] } },
            new Movie { Title = "Space Odyssey", ReleaseYear = 2022, Actors = new List<Actor> { actors[0], actors[5], actors[6] } },
            new Movie { Title = "Love in the Time of Chaos", ReleaseYear = 2019, Actors = new List<Actor> { actors[2], actors[7], actors[8] } },
            new Movie { Title = "The Last Stand", ReleaseYear = 2023, Actors = new List<Actor> { actors[3], actors[4], actors[9] } },
            new Movie { Title = "Journey to the Unknown", ReleaseYear = 2021, Actors = new List<Actor> { actors[5], actors[10], actors[11] } },
            new Movie { Title = "The Secret Agent", ReleaseYear = 2020, Actors = new List<Actor> { actors[6], actors[12], actors[13] } },
            new Movie { Title = "Underwater Mysteries", ReleaseYear = 2022, Actors = new List<Actor> { actors[1], actors[14], actors[15] } },
            new Movie { Title = "The Time Traveler", ReleaseYear = 2023, Actors = new List<Actor> { actors[0], actors[3], actors[16] } },
            new Movie { Title = "The Haunted House", ReleaseYear = 2021, Actors = new List<Actor> { actors[2], actors[4], actors[17] } },
            new Movie { Title = "The Final Countdown", ReleaseYear = 2020, Actors = new List<Actor> { actors[5], actors[6], actors[18] } },
            new Movie { Title = "The Great Heist", ReleaseYear = 2022, Actors = new List<Actor> { actors[7], actors[8], actors[19] } },
            new Movie { Title = "The Lost Treasure", ReleaseYear = 2021, Actors = new List<Actor> { actors[1], actors[9], actors[10] } },
            new Movie { Title = "The Last Resort", ReleaseYear = 2023, Actors = new List<Actor> { actors[11], actors[12], actors[13] } },
            new Movie { Title = "The Hidden Truth", ReleaseYear = 2020, Actors = new List<Actor> { actors[14], actors[15], actors[16] } },
            new Movie { Title = "The New Beginning", ReleaseYear = 2021, Actors = new List<Actor> { actors[17], actors[18], actors[19] } },
            new Movie { Title = "The Great Escape", ReleaseYear = 2022, Actors = new List<Actor> { actors[0], actors[1], actors[3] } },
            new Movie { Title = "The Final Battle", ReleaseYear = 2023, Actors = new List<Actor> { actors[4], actors[5], actors[6] } },
            new Movie { Title = "The Secret of the Forest", ReleaseYear = 2020, Actors = new List<Actor> { actors[7], actors[8], actors[9] } },
            new Movie { Title = "The Journey Home", ReleaseYear = 2021, Actors = new List<Actor> { actors[10], actors[11], actors[12] } },
            new Movie { Title = "The Forgotten Realm", ReleaseYear = 2022, Actors = new List<Actor> { actors[13], actors[14], actors[15] } },
            new Movie { Title = "The Edge of Tomorrow", ReleaseYear = 2023, Actors = new List<Actor> { actors[16], actors[17], actors[18] } },
            new Movie { Title = "The Road Less Traveled", ReleaseYear = 2021, Actors = new List<Actor> { actors[19], actors[0], actors[1] } }
        };

var beginLetter = "M";

var gafeMovies2 = (from m
                 in movies.Where(x => x.Title.StartsWith(beginLetter))
                   select m).ToArray(); // deferred execution
beginLetter = "T";

gafeMovies2.Dump();


// var gafeMovies = from m
//                  in movies.Where(x => x.Title.StartsWith("M"))
//                  group m by m.ReleaseYear into grp
//                  let nrOfMovies = grp.Count()
//                  orderby nrOfMovies
//                  select new { grp.Key, NrOfMovies = nrOfMovies };

// gafeMovies.Dump();














class Movie
{
    public string Title { get; set; }
    public int ReleaseYear { get; set; }
    public List<Actor> Actors { get; set; } = new();
}
class Actor
{
    public string Name { get; set; }

    public List<Movie> Movies { get; set; } = new();
}