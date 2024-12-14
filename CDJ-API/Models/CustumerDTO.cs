using System.ComponentModel.DataAnnotations;

namespace CDJ_API.Models;
public class CustumerDTO{
    [Required(ErrorMessage = "Error MC0x201: The data is required")]
    public string FirstName  { get; set; } = string.Empty;
    [Required(ErrorMessage = "Error MC0x202: The data is required")]
    public string LastName { get; set; } = string.Empty;
    [Required(ErrorMessage = "Error MC0x203: The data is required")]
    public string PhoneNumber {get; set;} =string.Empty;
    [Required(ErrorMessage = "Error MC0x204: The data is required")]
    public DateOnly BirthdayDate {get; set;}
}