using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace LocalPlex
{
	public class Part
	{

		[JsonProperty("id")]
		public int Id { get; set; }

		[JsonProperty("key")]
		public string Key { get; set; }

		[JsonProperty("duration")]
		public int Duration { get; set; }

		[JsonProperty("file")]
		public string File { get; set; }

		[JsonProperty("size")]
		public object Size { get; set; }

		[JsonProperty("audioProfile")]
		public string AudioProfile { get; set; }

		[JsonProperty("container")]
		public string Container { get; set; }

		[JsonProperty("videoProfile")]
		public string VideoProfile { get; set; }

		[JsonProperty("has64bitOffsets")]
		public bool? Has64bitOffsets { get; set; }

		[JsonProperty("hasChapterTextStream")]
		public bool? HasChapterTextStream { get; set; }

		[JsonProperty("optimizedForStreaming")]
		public bool? OptimizedForStreaming { get; set; }
	}

	public class Stream
	{

		[JsonProperty("id")]
		public int Id { get; set; }

		[JsonProperty("streamType")]
		public int StreamType { get; set; }

		[JsonProperty("default")]
		public bool Default { get; set; }

		[JsonProperty("codec")]
		public string Codec { get; set; }

		[JsonProperty("index")]
		public int Index { get; set; }

		[JsonProperty("bitrate")]
		public int Bitrate { get; set; }

		[JsonProperty("language")]
		public string Language { get; set; }

		[JsonProperty("languageCode")]
		public string LanguageCode { get; set; }

		[JsonProperty("bitDepth")]
		public int BitDepth { get; set; }

		[JsonProperty("chromaLocation")]
		public string ChromaLocation { get; set; }

		[JsonProperty("chromaSubsampling")]
		public string ChromaSubsampling { get; set; }

		[JsonProperty("codedHeight")]
		public int CodedHeight { get; set; }

		[JsonProperty("codedWidth")]
		public int CodedWidth { get; set; }

		[JsonProperty("colorPrimaries")]
		public string ColorPrimaries { get; set; }

		[JsonProperty("colorRange")]
		public string ColorRange { get; set; }

		[JsonProperty("colorSpace")]
		public string ColorSpace { get; set; }

		[JsonProperty("colorTrc")]
		public string ColorTrc { get; set; }

		[JsonProperty("frameRate")]
		public double FrameRate { get; set; }

		[JsonProperty("hasScalingMatrix")]
		public bool HasScalingMatrix { get; set; }

		[JsonProperty("height")]
		public int Height { get; set; }

		[JsonProperty("level")]
		public int Level { get; set; }

		[JsonProperty("profile")]
		public string Profile { get; set; }

		[JsonProperty("refFrames")]
		public int RefFrames { get; set; }

		[JsonProperty("scanType")]
		public string ScanType { get; set; }

		[JsonProperty("width")]
		public int Width { get; set; }

		[JsonProperty("displayTitle")]
		public string DisplayTitle { get; set; }

		[JsonProperty("extendedDisplayTitle")]
		public string ExtendedDisplayTitle { get; set; }

		[JsonProperty("selected")]
		public bool? Selected { get; set; }

		[JsonProperty("channels")]
		public int? Channels { get; set; }

		[JsonProperty("audioChannelLayout")]
		public string AudioChannelLayout { get; set; }

		[JsonProperty("samplingRate")]
		public int? SamplingRate { get; set; }

		[JsonProperty("title")]
		public string Title { get; set; }

		[JsonProperty("closedCaptions")]
		public string ClosedCaptions { get; set; }

		[JsonProperty("embeddedInVideo")]
		public string EmbeddedInVideo { get; set; }
	}

	public class Medium
	{

		[JsonProperty("id")]
		public int Id { get; set; }

		[JsonProperty("duration")]
		public int Duration { get; set; }

		[JsonProperty("bitrate")]
		public int Bitrate { get; set; }

		[JsonProperty("width")]
		public int Width { get; set; }

		[JsonProperty("height")]
		public int Height { get; set; }

		[JsonProperty("aspectRatio")]
		public double AspectRatio { get; set; }

		[JsonProperty("audioChannels")]
		public int AudioChannels { get; set; }

		[JsonProperty("audioCodec")]
		public string AudioCodec { get; set; }

		[JsonProperty("videoCodec")]
		public string VideoCodec { get; set; }

		[JsonProperty("videoResolution")]
		public string VideoResolution { get; set; }

		[JsonProperty("container")]
		public string Container { get; set; }

		[JsonProperty("videoFrameRate")]
		public string VideoFrameRate { get; set; }

		[JsonProperty("audioProfile")]
		public string AudioProfile { get; set; }

		[JsonProperty("videoProfile")]
		public string VideoProfile { get; set; }

		[JsonProperty("Part")]
		public IList<Part> Part { get; set; }

		[JsonProperty("optimizedForStreaming")]
		public int? OptimizedForStreaming { get; set; }

		[JsonProperty("Stream")]
		public IList<Stream> Stream { get; set; }

		[JsonProperty("has64bitOffsets")]
		public bool? Has64bitOffsets { get; set; }
	}

	public class TagData
	{

		[JsonProperty("tag")]
		public string Tag { get; set; }
	}

	public class Metadata
	{

		[JsonProperty("ratingKey")]
		public string RatingKey { get; set; }

		[JsonProperty("key")]
		public string Key { get; set; }

		[JsonProperty("guid")]
		public string Guid { get; set; }

		[JsonProperty("studio")]
		public string Studio { get; set; }

		[JsonProperty("type")]
		public string Type { get; set; }

		[JsonProperty("title")]
		public string Title { get; set; }

		[JsonProperty("contentRating")]
		public string ContentRating { get; set; }

		[JsonProperty("summary")]
		public string Summary { get; set; }

		[JsonProperty("rating")]
		public double Rating { get; set; }

		[JsonProperty("audienceRating")]
		public double AudienceRating { get; set; }

		[JsonProperty("viewOffset")]
		public int ViewOffset { get; set; }

		[JsonProperty("viewCount")]
		public int ViewCount { get; set; }

		[JsonProperty("lastViewedAt")]
		public int LastViewedAt { get; set; }

		[JsonProperty("year")]
		public int Year { get; set; }

		[JsonProperty("tagline")]
		public string Tagline { get; set; }

		[JsonProperty("thumb")]
		public string Thumb { get; set; }

		[JsonProperty("art")]
		public string Art { get; set; }

		[JsonProperty("duration")]
		public int Duration { get; set; }

		[JsonProperty("originallyAvailableAt")]
		public string OriginallyAvailableAt { get; set; }

		[JsonProperty("addedAt")]
		public int AddedAt { get; set; }

		[JsonProperty("updatedAt")]
		public int UpdatedAt { get; set; }

		[JsonProperty("audienceRatingImage")]
		public string AudienceRatingImage { get; set; }

		[JsonProperty("chapterSource")]
		public string ChapterSource { get; set; }

		[JsonProperty("ratingImage")]
		public string RatingImage { get; set; }

		[JsonProperty("Media")]
		public IList<Medium> Media { get; set; }

		[JsonProperty("Genre")]
		public IList<TagData> Genre { get; set; }

		[JsonProperty("Director")]
		public IList<TagData> Director { get; set; }

		[JsonProperty("Writer")]
		public IList<TagData> Writer { get; set; }

		[JsonProperty("Country")]
		public IList<TagData> Country { get; set; }

		[JsonProperty("Role")]
		public IList<TagData> Role { get; set; }

		[JsonProperty("primaryExtraKey")]
		public string PrimaryExtraKey { get; set; }




		[JsonProperty("librarySectionTitle")]
		public string LibrarySectionTitle { get; set; }

		[JsonProperty("librarySectionID")]
		public int LibrarySectionID { get; set; }

		[JsonProperty("librarySectionKey")]
		public string LibrarySectionKey { get; set; }


		[JsonProperty("skipCount")]
		public int SkipCount { get; set; }

		[JsonProperty("Collection")]
		public IList<TagData> Collection { get; set; }

		[JsonProperty("parentRatingKey")]
		public string ParentRatingKey { get; set; }

		[JsonProperty("grandparentRatingKey")]
		public string GrandparentRatingKey { get; set; }

		[JsonProperty("grandparentGuid")]
		public string GrandparentGuid { get; set; }

		[JsonProperty("grandparentKey")]
		public string GrandparentKey { get; set; }

		[JsonProperty("parentKey")]
		public string ParentKey { get; set; }

		[JsonProperty("grandparentTitle")]
		public string GrandparentTitle { get; set; }

		[JsonProperty("parentTitle")]
		public string ParentTitle { get; set; }

		[JsonProperty("index")]
		public int? Index { get; set; }

		[JsonProperty("parentIndex")]
		public int? ParentIndex { get; set; }


		[JsonProperty("grandparentThumb")]
		public string GrandparentThumb { get; set; }

		[JsonProperty("grandparentArt")]
		public string GrandparentArt { get; set; }

		[JsonProperty("grandparentTheme")]
		public string GrandparentTheme { get; set; }

		[JsonProperty("titleSort")]
		public string TitleSort { get; set; }

		[JsonProperty("parentGuid")]
		public string ParentGuid { get; set; }

		[JsonProperty("parentThumb")]
		public string ParentThumb { get; set; }

		[JsonProperty("parentStudio")]
		public string ParentStudio { get; set; }

		[JsonProperty("parentYear")]
		public int? ParentYear { get; set; }

		[JsonProperty("leafCount")]
		public int? LeafCount { get; set; }

		[JsonProperty("viewedLeafCount")]
		public int? ViewedLeafCount { get; set; }
	}
}
