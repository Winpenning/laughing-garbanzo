namespace CDJ_API.Models;
public class Product{
    public int Id { get; internal set; }
    public string Name {get; internal set;} = string.Empty;
    public string UnitType { get; internal set; } = string.Empty;
    public int UnitCount { get; internal set; }
    public decimal UnitPrice { get; internal set; }
    public Product(){}
    public Product(string name, string unitType, int unitCount, decimal unitPrice)
    {
        Name = name;
        UnitType = unitType;
        UnitCount = unitCount;
        UnitPrice = unitPrice;
    }
}