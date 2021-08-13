using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace LocalPlex
{
	public class HubSection
	{
		[JsonProperty("size")]
		public int Size { get; set; }

		[JsonProperty("totalSize")]
		public int TotalSize { get; set; }

		[JsonProperty("allowSync")]
		public bool AllowSync { get; set; }

		[JsonProperty("identifier")]
		public string Identifier { get; set; }

		[JsonProperty("offset")]
		public int Offset { get; set; }

		[JsonProperty("Hub")]
		public IList<Hub> Hub { get; set; }
	}

	public class Hub
	{
		[JsonProperty("hubKey")]
		public string HubKey { get; set; }

		[JsonProperty("key")]
		public string Key { get; set; }

		[JsonProperty("title")]
		public string Title { get; set; }

		[JsonProperty("type")]
		public string Type { get; set; }

		[JsonProperty("hubIdentifier")]
		public string HubIdentifier { get; set; }

		[JsonProperty("context")]
		public string Context { get; set; }

		[JsonProperty("size")]
		public int Size { get; set; }

		[JsonProperty("more")]
		public bool More { get; set; }

		[JsonProperty("style")]
		public string Style { get; set; }

		[JsonProperty("promoted")]
		public bool Promoted { get; set; }

		[JsonProperty("Metadata")]
		public IList<Metadata> Metadata { get; set; }
	}
}
