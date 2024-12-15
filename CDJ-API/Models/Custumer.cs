namespace CDJ_API.Models;
public class Custumer{
    public int Id { get; internal set; }
    public string FirstName  { get; internal set; } = string.Empty;
    public string LastName { get; internal set; } = string.Empty;
    public string PhoneNumber {get; internal set;} =string.Empty;
    public DateOnly BirthdayDate {get; internal set;}
    public Custumer(){}
    public Custumer(string firstName, string lastName, string phoneNumber, DateOnly birthdayDate){
        FirstName = firstName;
        LastName = lastName;
        PhoneNumber = phoneNumber;
        BirthdayDate = birthdayDate;
    }
}