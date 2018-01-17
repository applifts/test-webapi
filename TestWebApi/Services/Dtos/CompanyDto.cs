using System;

namespace TestWebApi.Services.Dtos
{
    public class CompanyDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address1{ get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zipcode { get; set; }
        public string PhoneNumber { get; set; }
        public string Notes { get; set; }
        public string POC {get ;set; } 
    }
}