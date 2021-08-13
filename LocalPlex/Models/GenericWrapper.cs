using Newtonsoft.Json;
namespace LocalPlex
{
	public class GenericWrapper<T>
	{
		[JsonProperty("MediaContainer")]
		public T Container { get; set; }
	}
}
