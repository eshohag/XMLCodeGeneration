using System.IO;
using System.Xml;

namespace XMLCodeGeneration
{
    public static class XmlSerializationHelper
    {
        public static string GetOuterXml(this XmlNode node, bool indent = true)
        {
            if (node == null)
                return null;
            using (var textWriter = new StringWriter())
            {
                var settings = new XmlWriterSettings
                {
                    Indent = indent,
                    OmitXmlDeclaration = true,
                };
                using (var xmlWriter = XmlWriter.Create(textWriter, settings))
                {
                    node.WriteTo(xmlWriter);
                }
                return textWriter.ToString();
            }
        }
    }

}
