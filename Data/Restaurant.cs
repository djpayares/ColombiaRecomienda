using System;

namespace BlazorMapaColombia.Data
{
	public class Restaurant
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Type { get; set; }
		public string Description { get; set; }
		public string Address { get; set; }
		public double Rating { get; set; }
		public int CityId { get; set; }

		// New properties
		public string ImageUrl { get; set; } // URL of the restaurant's image
		public string SocialMediaLink { get; set; } // Link to restaurant's social media
	}
}