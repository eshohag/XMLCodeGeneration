using System;
using System.Xml;

namespace XMLCodeGeneration
{
    class Program
    {
        static void Main(string[] args)
        {
            var soapNs = @"http://schemas.xmlsoap.org/soap/envelope/";
            var v1 = @"http://BaNCS.TCS.com/webservice/CreateCustomerInterface/v1";
            var v2 = @"http://TCS.BANCS.Adapter/BANCSSchema";
            string prefix = "ban";

            var doc = new XmlDocument();
            var root = doc.AppendChild(doc.CreateElement("", "Envelope", soapNs));
            var body = root.AppendChild(doc.CreateElement("", "Body", soapNs));
            var createCustomer = body.AppendChild(doc.CreateElement("", "createCustomer", v1));
            var custAddRq = createCustomer.AppendChild(doc.CreateElement("", "CustAddRq", ""));
            var rqHeader = custAddRq.AppendChild(doc.CreateElement("", "RqHeader", v2));

            rqHeader.AppendChild(doc.CreateElement("", "InstNum", v2)).InnerText = "003";
            rqHeader.AppendChild(doc.CreateElement("", "BrchNum", v2)).InnerText = "0001";

            var data = custAddRq.AppendChild(doc.CreateElement("", "Data", v2));
            data.AppendChild(doc.CreateElement("", "SSDone", v2)).InnerText = "N";

            var xml = doc.GetOuterXml();

            Console.ReadKey();
        }
    }
}
