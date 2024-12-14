namespace CDJ_API.Models;

public class Custumer{
    public int Id { get; set; }
    private string FirstName  { get; set; } = string.Empty;
    private string LastName { get; set; } = string.Empty;
    private string PhoneNumber {get; set;} =string.Empty;
    private DateOnly BirthdayDate {get; set;}

    public Custumer(){}

    public Custumer(string firstName, string lastName, string phoneNumber, DateOnly birthdayDate){
        FirstName = firstName;
        LastName = lastName;
        PhoneNumber = phoneNumber;
        BirthdayDate = birthdayDate;
    }
}