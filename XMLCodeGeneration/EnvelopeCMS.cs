using System.Collections.Generic;
using System.Xml.Serialization;

namespace XMLCodeGeneration
{
    // using System.Xml.Serialization;
    // XmlSerializer serializer = new XmlSerializer(typeof(Envelope));
    // using (StringReader reader = new StringReader(xml))
    // {
    //    var test = (Envelope)serializer.Deserialize(reader);
    // }

    [XmlRoot(ElementName = "RequestHeader")]
    public class RequestHeader
    {

        [XmlElement(ElementName = "Branch")]
        public int Branch { get; set; }

        [XmlElement(ElementName = "Station")]
        public int Station { get; set; }

        [XmlElement(ElementName = "RType")]
        public string RType { get; set; }

        [XmlElement(ElementName = "Cpimode")]
        public string Cpimode { get; set; }

        [XmlElement(ElementName = "User")]
        public string User { get; set; }

        [XmlElement(ElementName = "Pwd")]
        public string Pwd { get; set; }
    }

    [XmlRoot(ElementName = "Header")]
    public class Header
    {

        [XmlElement(ElementName = "RequestHeader")]
        public RequestHeader RequestHeader { get; set; }
    }

    [XmlRoot(ElementName = "Command")]
    public class Command
    {

        [XmlAttribute(AttributeName = "Action")]
        public string Action { get; set; }
    }

    [XmlRoot(ElementName = "ATTRIBUTE")]
    public class ATTRIBUTE
    {

        [XmlAttribute(AttributeName = "ID")]
        public string ID { get; set; }

        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "CUSTOMATTRIBUTES")]
    public class CUSTOMATTRIBUTES
    {

        [XmlElement(ElementName = "ATTRIBUTE")]
        public List<ATTRIBUTE> ATTRIBUTE { get; set; }
    }

    [XmlRoot(ElementName = "POSTALADDRESS")]
    public class POSTALADDRESS
    {

        [XmlElement(ElementName = "ZIPCODE")]
        public int ZIPCODE { get; set; }

        [XmlElement(ElementName = "LINE")]
        public string LINE { get; set; }
    }

    [XmlRoot(ElementName = "Person")]
    public class Person
    {

        [XmlElement(ElementName = "Command")]
        [XmlAttribute("Action")]
        public Command Command { get; set; }

        [XmlElement(ElementName = "CUSTOMATTRIBUTES")]
        public CUSTOMATTRIBUTES CUSTOMATTRIBUTES { get; set; }

        [XmlElement(ElementName = "FirstName")]
        public string FirstName { get; set; }

        [XmlElement(ElementName = "LastName")]
        [XmlAttribute("Action")]
        public string LastName { get; set; }

        [XmlElement(ElementName = "TITLE")]
        public int TITLE { get; set; }

        [XmlElement(ElementName = "Name")]
        public string Name { get; set; }

        [XmlElement(ElementName = "Sex")]
        public string Sex { get; set; }

        [XmlElement(ElementName = "BIRTHDATE")]
        public int BIRTHDATE { get; set; }

        [XmlElement(ElementName = "MOBILEPHONE")]
        public string MOBILEPHONE { get; set; }

        [XmlElement(ElementName = "CountryCitizen")]
        public int CountryCitizen { get; set; }

        [XmlElement(ElementName = "POSTALADDRESS")]
        public POSTALADDRESS POSTALADDRESS { get; set; }

        [XmlElement(ElementName = "BRANCHPART")]
        public int BRANCHPART { get; set; }
    }

    [XmlRoot(ElementName = "Request")]
    public class Request
    {

        [XmlElement(ElementName = "Person")]
        public Person Person { get; set; }

        [XmlElement(ElementName = "Request")]
        public Request Request1 { get; set; }
    }

    [XmlRoot(ElementName = "Body")]
    public class Body
    {

        [XmlElement(ElementName = "Request")]
        public Request Request { get; set; }
    }

    [XmlRoot(ElementName = "Envelope")]
    public class Envelope
    {

        [XmlElement(ElementName = "Header")]
        public Header Header { get; set; }

        [XmlElement(ElementName = "Body")]
        public Body Body { get; set; }
    }



}
