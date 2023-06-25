using System;
namespace Tutorial
{
	class Movie
	{
		public string title;
		public string director;
		private string rating;

		public Movie(string atitle, string adirector, string arating)
		{
			title = atitle;
			director = adirector;
			Rating = arating;
		}

		public string Rating
		{
			get { return rating; }
			set
			{
                if (value == "G" || value == "PG")
				{
					rating = value;
				}
				else
				{
					rating = "NR";
				}
			}
		}
	}
}

