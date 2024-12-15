namespace CDJ_API.Models;
public class Custumer{
    public int Id { get; private set; }
    public string FirstName  { get; private set; } = string.Empty;
    public string LastName { get; private set; } = string.Empty;
    public string PhoneNumber {get; private set;} =string.Empty;
    public DateOnly BirthdayDate {get; private set;}
    public Custumer(){}
    public Custumer(string firstName, string lastName, string phoneNumber, DateOnly birthdayDate){
        FirstName = firstName;
        LastName = lastName;
        PhoneNumber = phoneNumber;
        BirthdayDate = birthdayDate;
    }
}