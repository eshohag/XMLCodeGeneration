using System;
using System.Xml;

namespace XMLCodeGeneration
{
    class Program
    {
        static void Main(string[] args)
        {

            #region XMLBasicStructure
            var soapNs = @"http://schemas.xmlsoap.org/soap/envelope/";
            var cpi = @"http://schemas.compassplus.com/twcms/1.0/omsi.xsd";
            var v1 = @"http://TCS.BANCS.Adapter/BANCSSchema";
            var v2 = @"http://TCS.BANCS.Adapter/BANCSSchema";
            string prefix = "SOAP-ENV";

            var doc = new XmlDocument();
            var root = doc.AppendChild(doc.CreateElement(prefix, "Envelope", soapNs));
            var header = root.AppendChild(doc.CreateElement(prefix, "Header", soapNs));
            var requestHeader = header.AppendChild(doc.CreateElement("cpi", "RequestHeader", cpi));
            requestHeader.AppendChild(doc.CreateElement("", "Branch", "")).InnerText = "1";
            requestHeader.AppendChild(doc.CreateElement("", "Station", "")).InnerText = "90151";
            requestHeader.AppendChild(doc.CreateElement("", "RType", "")).InnerText = "Do";
            requestHeader.AppendChild(doc.CreateElement("", "Cpimode", "")).InnerText = "Sync";
            requestHeader.AppendChild(doc.CreateElement("", "User", "")).InnerText = "IBOMS";
            requestHeader.AppendChild(doc.CreateElement("", "Pwd", "")).InnerText = "IBOMS";


            var body = root.AppendChild(doc.CreateElement(prefix, "Body", soapNs));
            var request = body.AppendChild(doc.CreateElement("cpi", "Request", cpi));
            var request2 = request.AppendChild(doc.CreateElement("", "Request", ""));
            var person = request2.AppendChild(doc.CreateElement("", "Person", ""));

            XmlElement Command = doc.CreateElement("", "Command", "");
            Command.SetAttribute("Action", "Create");
            person.AppendChild(Command);

            var customeAttributes = person.AppendChild(doc.CreateElement("", "CUSTOMATTRIBUTES", ""));
            XmlElement attributeF = doc.CreateElement("", "ATTRIBUTE", "");
            attributeF.SetAttribute("ID", "FATHERNAME");
            customeAttributes.AppendChild(attributeF).InnerText = "Fathers name of customer";

            XmlElement attributeM = doc.CreateElement("", "ATTRIBUTE", "");
            attributeM.SetAttribute("ID", "MOTHERNAME");
            customeAttributes.AppendChild(attributeM).InnerText = "MOTHERNAME name of customer";

            person.AppendChild(doc.CreateElement("Name")).InnerText = "MD Shohag Mia";
            person.AppendChild(doc.CreateElement("LastName")).InnerText = "MD Shohag";
            person.AppendChild(doc.CreateElement("FirstName")).InnerText = "Mia";
            person.AppendChild(doc.CreateElement("TITLE")).InnerText = "1";
            person.AppendChild(doc.CreateElement("Sex")).InnerText = "M";
            person.AppendChild(doc.CreateElement("BIRTHDATE")).InnerText = "19850315";
            person.AppendChild(doc.CreateElement("MOBILEPHONE")).InnerText = "880(191)8111460";
            person.AppendChild(doc.CreateElement("CountryCitizen")).InnerText = "50";
            person.AppendChild(doc.CreateElement("BRANCHPART")).InnerText = "1";


            XmlElement postalAddress = doc.CreateElement("", "POSTALADDRESS", "");
            postalAddress.SetAttribute("TYPE", "3");
            var postalInfo = person.AppendChild(postalAddress);
            postalInfo.AppendChild(doc.CreateElement("ZIPCODE")).InnerText = "1200";
            postalInfo.AppendChild(doc.CreateElement("LINE")).InnerText = "DHAKA";

            var xml = doc.GetOuterXml();
            #endregion




            #region Comment TCS
            //var propertiesRqHeader = typeof(RqHeader_Type_Custom).GetProperties();

            //foreach (PropertyInfo property in propertiesRqHeader)
            //{
            //    var propValue = property.GetValue(aAddCustomer.RqHeader, null);
            //    if (propValue != null && !string.IsNullOrWhiteSpace(propValue.ToString()))
            //        rqHeader.AppendChild(doc.CreateElement(string.IsNullOrWhiteSpace(prefix) ? "" : prefix, property.Name, v2)).InnerText = propValue == null ? "" : propValue.ToString();
            //}
            //var propertiesData = typeof(CustAddRqData_Type_Custom).GetProperties();
            //foreach (PropertyInfo property in propertiesData)
            //{
            //    var propValue = property.GetValue(aAddCustomer.Data, null);
            //    if (propValue != null && !string.IsNullOrWhiteSpace(propValue.ToString()))
            //        data.AppendChild(doc.CreateElement(string.IsNullOrWhiteSpace(prefix) ? "" : prefix, property.Name, v2)).InnerText = propValue == null ? "" : propValue.ToString();
            //}
            //var generatedXML = doc.GetOuterXml();

            #endregion

            Console.ReadKey();
        }

    }
}
