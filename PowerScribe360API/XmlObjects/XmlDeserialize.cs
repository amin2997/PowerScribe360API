using System.IO;
using System.Xml.Serialization;

namespace PowerScribe360Api.XmlObjects
{
	public static class XmlDeserialize<T>
	{
		public static T Deserialize(string xmlContent, string xmlRootAttribute="")
		{
			XmlSerializer serializer = null;

			if(string.IsNullOrWhiteSpace(xmlRootAttribute))
				serializer = new XmlSerializer(typeof(T));
			else
				serializer = new XmlSerializer(typeof(T), new XmlRootAttribute(xmlRootAttribute));


			using (TextReader reader = new StringReader(xmlContent))
			{
				return (T)serializer.Deserialize(reader);
			}
		}
	}
}