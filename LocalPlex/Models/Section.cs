using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace LocalPlex
{
	public class Sections
	{
		[JsonProperty("size")]
		public int Size { get; set; }

		[JsonProperty("totalSize")]
		public int TotalSize { get; set; }

		[JsonProperty("offset")]
		public int Offset { get; set; }

		[JsonProperty("allowSync")]
		public bool AllowSync { get; set; }

		[JsonProperty("art")]
		public string Art { get; set; }

		[JsonProperty("content")]
		public string Content { get; set; }

		[JsonProperty("identifier")]
		public string Identifier { get; set; }

		[JsonProperty("librarySectionID")]
		public int LibrarySectionID { get; set; }

		[JsonProperty("mediaTagPrefix")]
		public string MediaTagPrefix { get; set; }

		[JsonProperty("mediaTagVersion")]
		public int MediaTagVersion { get; set; }

		[JsonProperty("sortAsc")]
		public bool SortAsc { get; set; }

		[JsonProperty("thumb")]
		public string Thumb { get; set; }

		[JsonProperty("title1")]
		public string Title1 { get; set; }

		[JsonProperty("viewGroup")]
		public string ViewGroup { get; set; }

		[JsonProperty("viewMode")]
		public int ViewMode { get; set; }

		[JsonProperty("Directory")]
		public IList<Directory> Directory { get; set; }

		[JsonProperty("Metadata")]
		public IList<Metadata> Metadata { get; set; }

		public bool HasMore => TotalSize > Size + Offset;
	}
}
