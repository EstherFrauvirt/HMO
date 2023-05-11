namespace DTO
{
    public class MemberDTO
    {
        public int MemberId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Id { get; set; }

        public string City { get; set; }

        public string Adress { get; set; }

        public DateTime BirthDate { get; set; }

        public string? Phone { get; set; }

        public string? MobilePhone { get; set; }

        public DateTime? DiseaseDate { get; set; }

        public DateTime? RecoveryDate { get; set; }
    }
}