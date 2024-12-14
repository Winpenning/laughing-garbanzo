namespace CDJ_API.Models;
public class Custumer{
    internal int Id { get; set; }
    internal string FirstName  { get; set; } = string.Empty;
    internal string LastName { get; set; } = string.Empty;
    internal string PhoneNumber {get; set;} =string.Empty;
    internal DateOnly BirthdayDate {get; set;}
    public Custumer(){}
    public Custumer(string firstName, string lastName, string phoneNumber, DateOnly birthdayDate){
        FirstName = firstName;
        LastName = lastName;
        PhoneNumber = phoneNumber;
        BirthdayDate = birthdayDate;
    }
}