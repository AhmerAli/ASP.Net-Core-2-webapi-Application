using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

public class EmployeeProfile : IdentityUser
{
    [Required]
    public long Employee_ID { get; set; }
    [Required]
    public string First_Name { get; set; }
    public string Middle_Name { get; set; }
    [Required]
    public string Last_Name { get; set; }
    [Required]
    public string City { get; set; }
    [Required]
    public string Address_1 { get; set; }
    public string Address_2 { get; set; }
    [Required]
    public string Contact_No { get; set; }
    public long? Supervisor { get; set; }
    public string Designation { get; set; }
    public string Group_Level { get; set; }
    public string CRC { get; set; }
    //public long? FacebookId { get; set; }
    //public string PictureUrl { get; set; }
}