using System;
using Newtonsoft.Json;

namespace LocalPlex
{
	public class Location
	{
		[JsonProperty("id")]
		public int Id { get; set; }

		[JsonProperty("path")]
		public string Path { get; set; }
	}

}
