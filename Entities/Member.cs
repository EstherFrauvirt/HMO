using System;
using System.Collections.Generic;

namespace Entities;

public partial class Member
{
    public int MemberId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Id { get; set; }

    public string? City { get; set; }

    public string? Adress { get; set; }

    public DateTime? BirthDate { get; set; }

    public string? Phone { get; set; }

    public string? MobilePhone { get; set; }

    public DateTime? DiseaseDate { get; set; }

    public DateTime? RecoveryDate { get; set; }

    public virtual ICollection<Vaccination> Vaccinations { get; set; } = new List<Vaccination>();
}
