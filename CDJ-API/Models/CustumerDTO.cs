using Microsoft.AspNetCore.Mvc;

namespace CDJ_API.Models;
public class CustumerDTO{
    public required string FirstName  { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string PhoneNumber {get; set;} =string.Empty;
    public DateOnly BirthdayDate {get; set;}
}