using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace LocalPlex
{
	public class Directory
	{
		[JsonProperty("allowSync")]
		public bool AllowSync { get; set; }

		[JsonProperty("art")]
		public string Art { get; set; }

		[JsonProperty("composite")]
		public string Composite { get; set; }

		[JsonProperty("filters")]
		public bool Filters { get; set; }

		[JsonProperty("refreshing")]
		public bool Refreshing { get; set; }

		[JsonProperty("thumb")]
		public string Thumb { get; set; }

		public string ParentKey { get; set; }

		[JsonProperty("key")]
		public string Key { get; set; }

		[JsonProperty("type")]
		public string Type { get; set; }

		[JsonProperty("title")]
		public string Title { get; set; }

		[JsonProperty("agent")]
		public string Agent { get; set; }

		[JsonProperty("scanner")]
		public string Scanner { get; set; }

		[JsonProperty("secondary")]
		public bool? Secondary { get; set; }

		[JsonProperty("language")]
		public string Language { get; set; }

		[JsonProperty("uuid")]
		public string Uuid { get; set; }

		[JsonProperty("updatedAt")]
		public int UpdatedAt { get; set; }

		[JsonProperty("createdAt")]
		public int CreatedAt { get; set; }

		[JsonProperty("scannedAt")]
		public int ScannedAt { get; set; }

		[JsonProperty("content")]
		public bool Content { get; set; }

		[JsonProperty("directory")]
		public bool IsDirectory { get; set; }

		[JsonProperty("contentChangedAt")]
		public int ContentChangedAt { get; set; }

		[JsonProperty("hidden")]
		public int Hidden { get; set; }

		[JsonProperty("prompt")]
		public string Prompt { get; set; }

		[JsonProperty("search")]
		public bool? Search { get; set; }

		[JsonProperty("Location")]
		public IList<Location> Location { get; set; }

		public string GetFullKeyPath => string.IsNullOrWhiteSpace(ParentKey) ? Key : $"{ParentKey}/{Key}";
	}
}
