// Data/City.cs
using System.Collections.Generic;

namespace BlazorMapaColombia.Data
{
	public class City
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public string ImagePath { get; set; }
		public double Latitude { get; set; }
		public double Longitude { get; set; }
	}
}