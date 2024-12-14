using System.Text.Json;
using System.Text.Json.Serialization;

namespace CDJ_API.Models;

public class Custumer{
    [JsonInclude]
    private int Id { get; set; }
    [JsonInclude]
    private string FirstName  { get; set; } = string.Empty;
    [JsonInclude]
    private string LastName { get; set; } = string.Empty;
    [JsonInclude]
    private string PhoneNumber {get; set;} =string.Empty;
    [JsonInclude]
    private DateOnly BirthdayDate {get; set;}
    public Custumer(){}

    public Custumer(string firstName, string lastName, string phoneNumber, DateOnly birthdayDate){
        FirstName = firstName;
        LastName = lastName;
        PhoneNumber = phoneNumber;
        BirthdayDate = birthdayDate;
    }

    public Custumer GetInstance(){
        return this;
    }
    public string GetJson(){
        var options = new JsonSerializerOptions{
            WriteIndented = true
        };
        return JsonSerializer.Serialize(this, options);
    }
}