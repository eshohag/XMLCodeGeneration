namespace XMLCodeGeneration
{
    public class CustAddRq_Type_Custom
    {
        public CustAddRq_Type_Custom()
        {
            RqHeader = new RqHeader_Type_Custom();
            Data = new CustAddRqData_Type_Custom();
        }

        public RqHeader_Type_Custom RqHeader { get; set; }
        public CustAddRqData_Type_Custom Data { get; set; }
    }

    public class CustAddRqData_Type_Custom
    {
        public string NidVrfy { get; set; }
        public string SSDone { get; set; }
        public string SelfSPouseParent { get; set; }
        public string DocObtainAddr { get; set; }
        public string FormrAddrProof { get; set; }
        public string AddrProofObtain { get; set; }
        public string HasAddrBeenVrfy { get; set; }
        public string HowTheAddrVrfy { get; set; }
        public string FrillNoFlag { get; set; }
        public string MaritalStat { get; set; }
        public string CustLastName { get; set; }
        public string BengaliName { get; set; }
        public string SpouseName { get; set; }
        public string DisblFlag { get; set; }
        public string Natlty2 { get; set; }
        public string Natlty3 { get; set; }
        public string Flag1 { get; set; }
        public string CustRisk { get; set; }
        public string ReguLike { get; set; }
        public string ReguImp { get; set; }
        public string DevChanl2 { get; set; }
        public string ProdServ2 { get; set; }
        public string Designation { get; set; }
        public string ProdServ1 { get; set; }
        public string Attr7 { get; set; }
        public string DevChanl1 { get; set; }
        public string UsCust { get; set; }
        public string Usw9form { get; set; }
        public string Usgreencard { get; set; }
        public string UsAddrFlag { get; set; }
        public string UsPwrAttorny { get; set; }
        public string UsStayed { get; set; }
        public string UsPaySrc { get; set; }
        public string CentreCode { get; set; }
        public string AgntCode { get; set; }
        public string MoblieEmg { get; set; }
        public string MadeInIndia { get; set; }
        public string OfcAddr { get; set; }
        public string RelnEmg { get; set; }
        public string CountryEmg { get; set; }
        public string Div { get; set; }
        public string DisttCode { get; set; }
        public string FinclInclsn { get; set; }
        public string IssueAuthty { get; set; }
        public string IdIssuePlace { get; set; }
        public string IdIssueDt { get; set; }
        public string ApprvlOfSenior { get; set; }
        public string IsTheFamily { get; set; }
        public string GreetingReqd { get; set; }
        public string ProfCentr { get; set; }
        public string LckrHldr { get; set; }
        public string Caste { get; set; }
        public string ProofAddrTyp { get; set; }
        public string RiskScoreMat { get; set; }
        public string NameEmg { get; set; }
        public string SubOfc2 { get; set; }
        public string Thana1 { get; set; }
        public string SubOfc1 { get; set; }
        public string Thana2 { get; set; }
        public string CityCode1 { get; set; }
        public string CityCode { get; set; }
        public string StateCode1 { get; set; }
        public string State { get; set; }
        public string BussPhnNum { get; set; }
        public string CountryCode { get; set; }
        public string CountryCode2 { get; set; }
        public string NrstLndMark { get; set; }
        public string IsTheCust { get; set; }
        public string NameAsProof { get; set; }
        public string PolitclEP { get; set; }
        public string MnthlyIncome { get; set; }
        public string CustTyp { get; set; }
        public string TitleCode { get; set; }
        public string CustFirstName { get; set; }
        public string Addr11 { get; set; }
        public string Addr12 { get; set; }
        public string Addr10 { get; set; }
        public string Addr9 { get; set; }
        public string Addr1 { get; set; }
        public string Addr2 { get; set; }
        public string CountryCode1 { get; set; }
        public string Natlty { get; set; }
        public string AcctNum1 { get; set; }
        public string IntroName { get; set; }
        public string Relcusm { get; set; }
        public string NumAcct { get; set; }
        public string MobileNum235 { get; set; }
        public string AcctBrnch { get; set; }
        public string LangCode { get; set; }
        public string PpVrfy { get; set; }
        public string IdNum1 { get; set; }
        public string IdTyp1 { get; set; }
        public string IdExpryDt { get; set; }
        public string DmstcRisk { get; set; }
        public string CrossBrdrRisk { get; set; }
        public string SegCode { get; set; }
        public string HomeBrchNum { get; set; }
        public string CountryRisk { get; set; }
        public string GrpCode { get; set; }
        public string FatherName { get; set; }
        public string MotherMdnName { get; set; }
        public string DtOfBirth { get; set; }
        public string ResdncyCode { get; set; }
        public string OrigCode { get; set; }
        public string StrtCode { get; set; }
        public string GndrCode { get; set; }
        public string CustGrp { get; set; }
        public string CountryOfRsdnc { get; set; }
        public string RevaltnFlag { get; set; }
        public string OccupCode { get; set; }
        public string PrevOccupCode { get; set; }
        public string IncomeRange { get; set; }
        public string CustRiskImp { get; set; }
        public string CountryOfBirth { get; set; }
        public string CountryOfTaxRsdnc { get; set; }
        public string CounRiskImp { get; set; }
        public string CaptureProprietor { get; set; }
        public string PrimTyp1 { get; set; }
        public string SecndTyp1 { get; set; }
        public string PrimTyp2 { get; set; }
        public string DisttBirth { get; set; }
        public string SmeTyp { get; set; }
        public string BankNm { get; set; }
        public string CorrAddrLan { get; set; }
        public string CorrAddrMobile { get; set; }
        public string EmergencyContactMobile { get; set; }
    }
    public class RqHeader_Type_Custom
    {
        public string InstNum { get; set; }
        public string TellerNum { get; set; }
        public string BrchNum { get; set; }
        public string UUIDSource { get; set; }
        public string Flag5 { get; set; }
        public string Flag4 { get; set; }
        public string UUIDNUM { get; set; }
        public string UUIDSeqNo { get; set; }
    }
}
