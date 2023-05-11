namespace DTO;
using System.ComponentModel.DataAnnotations;

public class MemberDTO
{
    public int? MemberId { get; set; }

    [Required(ErrorMessage = "first name is require")]
    public string FirstName { get; set; }

    [Required(ErrorMessage = "last name is require")]
    public string LastName { get; set; }

    [StringLength(10)]
    public string Id { get; set; }

    public string City { get; set; }

    public string Adress { get; set; }

    [Required(ErrorMessage = "birth date is require")]
    public DateTime BirthDate { get; set; }

    
    [Phone]
    public string Phone { get; set; }

    [Required]
    [Phone]
    public string MobilePhone { get; set; }

    public DateTime DiseaseDate { get; set; }

    public DateTime RecoveryDate { get; set; }
}