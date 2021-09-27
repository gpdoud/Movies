﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies
{
	class Movie
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public string Genre { get; set; }
		public string Rating { get; set; } = "PG";
		public int Released { get; set; } // year only
		public int RuntimeInMinutes { get; set; }
		public string Director { get; set; }

		public Movie() { }
		public Movie(int id, string title, string genre, string rating,
					int released, int runtimeInMinutes, string director)
		{
			this.Id = id;
			this.Title = title;
			this.Genre = genre;
			this.Rating = rating;
			this.Released = released;
			this.RuntimeInMinutes = runtimeInMinutes;
			this.Director = director;
		}
	}
}
