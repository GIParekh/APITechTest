namespace APITechTest.ViewModels
{
    public class CompanyWithInsuranceStatusViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string Postcode { get; set; }
        public string Country { get; set; }
        public bool Active { get; set; }
        public DateTime InsuranceEndDate { get; set; }

        public bool IsInsurancePolicyActive { get; set; }
        public string InsurancePolicyStatus { get; set; }
    }
}
