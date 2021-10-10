using System;
using System.Reflection;
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
            string prefix = "";

            var doc = new XmlDocument();
            var root = doc.AppendChild(doc.CreateElement("", "Envelope", soapNs));
            var body = root.AppendChild(doc.CreateElement("", "Body", soapNs));
            var createCustomer = body.AppendChild(doc.CreateElement("", "createCustomer", v1));
            var custAddRq = createCustomer.AppendChild(doc.CreateElement("", "CustAddRq", ""));

            var rqHeader = custAddRq.AppendChild(doc.CreateElement("", "RqHeader", v2));
            var data = custAddRq.AppendChild(doc.CreateElement("", "Data", v2));

            #region Object Mapping
            var aAddCustomer = new CustAddRq_Type_Custom();
            aAddCustomer.RqHeader = new RqHeader_Type_Custom();
            aAddCustomer.Data = new CustAddRqData_Type_Custom();

            #region Request_Header Accroding to CreateCustomerInterfaceHttpService
            aAddCustomer.RqHeader.InstNum = "003";
            aAddCustomer.RqHeader.BrchNum = "0001";
            aAddCustomer.RqHeader.TellerNum = "5000055";
            aAddCustomer.RqHeader.Flag4 = "W";
            aAddCustomer.RqHeader.Flag5 = "Y";
            aAddCustomer.RqHeader.UUIDSource = "WS";
            aAddCustomer.RqHeader.UUIDNUM = "009";
            aAddCustomer.RqHeader.UUIDSeqNo = "0";

            #endregion

            #region Request_Data Accroding to CreateCustomerInterfaceHttpService
            aAddCustomer.Data.NidVrfy = "Y";
            aAddCustomer.Data.SSDone = "N";
            aAddCustomer.Data.FormrAddrProof = "N";
            aAddCustomer.Data.AddrProofObtain = "05";
            aAddCustomer.Data.DocObtainAddr = "05";
            aAddCustomer.Data.SelfSPouseParent = "N";
            aAddCustomer.Data.HasAddrBeenVrfy = "Y";
            aAddCustomer.Data.HowTheAddrVrfy = "1";
            aAddCustomer.Data.FrillNoFlag = "N";
            aAddCustomer.Data.MaritalStat = "M";
            aAddCustomer.Data.CustLastName = "TAZUL";
            aAddCustomer.Data.BengaliName = "Name IN bangali";
            aAddCustomer.Data.SpouseName = "Md.Anser Ali";
            aAddCustomer.Data.DisblFlag = "N";
            aAddCustomer.Data.Natlty2 = "BD";
            aAddCustomer.Data.Natlty3 = "BD";
            //aAddCustomer.Data.Attr7 = "N";
            aAddCustomer.Data.Attr7 = "01777777777";
            aAddCustomer.Data.Flag1 = "Y";
            aAddCustomer.Data.CustRisk = "09";
            aAddCustomer.Data.ReguLike = "2";
            aAddCustomer.Data.ReguImp = "3";
            aAddCustomer.Data.ProdServ1 = "2";
            aAddCustomer.Data.ProdServ2 = "3";
            aAddCustomer.Data.DevChanl1 = "2";
            aAddCustomer.Data.DevChanl2 = "3";
            aAddCustomer.Data.Designation = "16";
            aAddCustomer.Data.UsCust = "N";
            aAddCustomer.Data.Usgreencard = "N";
            aAddCustomer.Data.Usw9form = "N";
            aAddCustomer.Data.UsAddrFlag = "N";
            aAddCustomer.Data.UsPwrAttorny = "N";
            aAddCustomer.Data.UsStayed = "N";
            aAddCustomer.Data.UsPaySrc = "N";
            aAddCustomer.Data.CentreCode = "AB000116";
            aAddCustomer.Data.AgntCode = "US000726";
            aAddCustomer.Data.MoblieEmg = "01999999999";
            aAddCustomer.Data.MadeInIndia = "616";
            aAddCustomer.Data.OfcAddr = "1209";
            aAddCustomer.Data.RelnEmg = "04";
            aAddCustomer.Data.CountryEmg = "BD";
            aAddCustomer.Data.Div = "060";
            aAddCustomer.Data.DisttCode = "091";
            aAddCustomer.Data.FinclInclsn = "N";
            aAddCustomer.Data.IssueAuthty = "Barishal";
            aAddCustomer.Data.IdIssuePlace = "Barishal";
            aAddCustomer.Data.IdIssueDt = "01012008";
            aAddCustomer.Data.ApprvlOfSenior = "N";
            aAddCustomer.Data.IsTheFamily = "N";
            aAddCustomer.Data.GreetingReqd = "0";
            aAddCustomer.Data.ProfCentr = "00";
            aAddCustomer.Data.LckrHldr = "";
            aAddCustomer.Data.Caste = "004";
            aAddCustomer.Data.ProofAddrTyp = "Present Address";
            aAddCustomer.Data.RiskScoreMat = "3";
            aAddCustomer.Data.NameEmg = "NameEmg 007";
            aAddCustomer.Data.SubOfc2 = "7800";
            aAddCustomer.Data.SubOfc1 = "1209";
            aAddCustomer.Data.Thana1 = "616";
            aAddCustomer.Data.Thana2 = "632";
            aAddCustomer.Data.CityCode1 = "006";
            aAddCustomer.Data.CityCode = "026";
            aAddCustomer.Data.StateCode1 = "010";
            aAddCustomer.Data.State = "030";
            aAddCustomer.Data.BussPhnNum = "0188888888888";
            aAddCustomer.Data.CountryCode = "BD";
            aAddCustomer.Data.CountryCode2 = "BD";
            aAddCustomer.Data.NrstLndMark = "Mohammodpur";
            aAddCustomer.Data.NameAsProof = "NameAsProof";
            aAddCustomer.Data.IsTheCust = "N";
            aAddCustomer.Data.PolitclEP = "10";
            aAddCustomer.Data.MnthlyIncome = "150000";
            aAddCustomer.Data.CustTyp = "01";
            aAddCustomer.Data.TitleCode = "02";
            aAddCustomer.Data.CustFirstName = "Tazul";
            aAddCustomer.Data.Addr11 = "Address 11";
            aAddCustomer.Data.Addr12 = "Address 12";
            aAddCustomer.Data.Addr10 = "Address 10 ";
            aAddCustomer.Data.Addr9 = "Address 9 need to test";
            aAddCustomer.Data.Addr1 = "Address 1";
            aAddCustomer.Data.Addr2 = "Address 2";
            aAddCustomer.Data.CountryCode1 = "BD";
            aAddCustomer.Data.Natlty = "BD";
            aAddCustomer.Data.AcctNum1 = "113039058";
            aAddCustomer.Data.IntroName = "Mr WAHIDUZZAMAN";
            aAddCustomer.Data.Relcusm = "06";
            aAddCustomer.Data.NumAcct = "1130310293845";
            aAddCustomer.Data.MobileNum235 = "01712671832";
            aAddCustomer.Data.AcctBrnch = "00113";
            aAddCustomer.Data.LangCode = "01";
            aAddCustomer.Data.PpVrfy = "N";
            aAddCustomer.Data.IdNum1 = "5955963891";
            aAddCustomer.Data.IdTyp1 = "01";
            aAddCustomer.Data.IdExpryDt = "";
            aAddCustomer.Data.DmstcRisk = "ZZ";
            aAddCustomer.Data.CrossBrdrRisk = "ZZ";
            aAddCustomer.Data.SegCode = "0001";
            aAddCustomer.Data.HomeBrchNum = "113";
            aAddCustomer.Data.CountryRisk = "02";
            aAddCustomer.Data.GrpCode = "ZZ";
            aAddCustomer.Data.FatherName = "Farid Ahmad";
            aAddCustomer.Data.MotherMdnName = "Nazmun nahar";
            aAddCustomer.Data.DtOfBirth = "25011994";
            aAddCustomer.Data.ResdncyCode = "1";
            aAddCustomer.Data.OrigCode = "ZZ";
            aAddCustomer.Data.StrtCode = "ZZ";
            aAddCustomer.Data.GndrCode = "M";
            aAddCustomer.Data.CustGrp = "0103";
            aAddCustomer.Data.CountryOfRsdnc = "BD";
            aAddCustomer.Data.RevaltnFlag = "N";
            aAddCustomer.Data.OccupCode = "F";
            aAddCustomer.Data.PrevOccupCode = "0025";
            aAddCustomer.Data.IncomeRange = "01";
            aAddCustomer.Data.CustRiskImp = "3";
            aAddCustomer.Data.CountryOfBirth = "BD";
            aAddCustomer.Data.CountryOfTaxRsdnc = "BD";
            aAddCustomer.Data.CounRiskImp = "3";
            aAddCustomer.Data.CaptureProprietor = "N";
            aAddCustomer.Data.PrimTyp1 = "04";
            aAddCustomer.Data.SecndTyp1 = "03";
            aAddCustomer.Data.PrimTyp2 = "915001";
            aAddCustomer.Data.DisttBirth = "006";
            aAddCustomer.Data.SmeTyp = "00";
            aAddCustomer.Data.BankNm = "123";
            aAddCustomer.Data.CorrAddrLan = "+88";
            aAddCustomer.Data.CorrAddrMobile = "+88";
            aAddCustomer.Data.EmergencyContactMobile = "+88";
            #endregion

            #endregion

            var propertiesRqHeader = typeof(RqHeader_Type_Custom).GetProperties();

            foreach (PropertyInfo property in propertiesRqHeader)
            {
                var propValue = property.GetValue(aAddCustomer.RqHeader, null);
                if (propValue != null && !string.IsNullOrWhiteSpace(propValue.ToString()))
                    rqHeader.AppendChild(doc.CreateElement(string.IsNullOrWhiteSpace(prefix) ? "" : prefix, property.Name, v2)).InnerText = propValue == null ? "" : propValue.ToString();
            }
            var propertiesData = typeof(CustAddRqData_Type_Custom).GetProperties();
            foreach (PropertyInfo property in propertiesData)
            {
                var propValue = property.GetValue(aAddCustomer.Data, null);
                if (propValue != null && !string.IsNullOrWhiteSpace(propValue.ToString()))
                    data.AppendChild(doc.CreateElement(string.IsNullOrWhiteSpace(prefix) ? "" : prefix, property.Name, v2)).InnerText = propValue == null ? "" : propValue.ToString();
            }
            var generatedXML = doc.GetOuterXml();

            Console.ReadKey();
        }
    }
}

