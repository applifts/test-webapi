namespace TestWebApi.Domain.Entities
{
    public class People
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address1{ get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zipcode { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Skill1 { get; set; }
        public string Skill2 { get; set; }
        public string Skill3 { get; set; }
        public string Company { get; set; }
        public string Notes { get; set; }
        public string Type { get; set; }
        public string POC { get; set; }
        public int YearsExp { get; set; }

        public float PayRate { get; set; }

        public float BillRate { get; set; }
        
        public System.DateTime AvailableDate { get; set; }        
    }
}