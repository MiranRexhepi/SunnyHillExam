using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace SunnyHillTest.Areas.Identity.Data;

// Add profile data for application users by adding properties to the ApplicationUser class
public class ApplicationUser : IdentityUser
{
    [Required]
    [PersonalData]
    [Column(TypeName = "varchar(50)")]
    public string FirstName { get; set; }

    [Required]
    [PersonalData]
    [Column(TypeName = "varchar(50)")]
    public string LastName { get; set; }
    [Required]
    [PersonalData]
    [Column(TypeName = "varchar(50)")]
    public string PhoneNumber { get; set; }
    [Required]
    [PersonalData]
    [Column(TypeName = "varchar(15)")]
    public string BirthDate { get; set; }
    [Required]
    [PersonalData]
    [Column(TypeName = "varchar(2)")]
    public string Gender { get; set; }
    [Required]
    [PersonalData]
    [Column(TypeName = "varchar(50)")]
    public string Address { get; set; }



}

