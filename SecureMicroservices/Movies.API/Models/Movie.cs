namespace Movies.API.Models
{
	public class Movie
	{
		public int Id { get; set; }
		public string Title { get; set; } = string.Empty;
		public string Genre { get; set; }
		public DateTime ReleaseDate { get; set; }
		public string Owner { get; set; } = string.Empty;
	}
}
