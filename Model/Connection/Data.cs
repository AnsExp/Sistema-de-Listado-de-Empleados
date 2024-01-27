using System.Xml;

namespace Model.Connection
{
    public sealed class Data
    {
        private Data()
        {
            doc = new XmlDocument();
            doc.Load("../../../Resources/config.xml");
        }

        private static XmlDocument doc;

        public static string Get(string key)
        {
            if (doc == null)
                new Data();

            XmlNode node = doc.SelectSingleNode("/appSettings/setting[@key=\'" + key + "\']");
            XmlAttribute attribute = node.Attributes["value"];
            return attribute.Value;
        }
    }
}
