using System.ComponentModel.DataAnnotations;

namespace CDJ_API.Models;
public class ProductDTO{
    [Required(ErrorMessage = "MP0x401: The data is required")]
    public string Name {get; set;} = string.Empty;
    [Required(ErrorMessage = "MP0x402: The data is required")]
    public string UnitType { get; set; } = string.Empty;
    [Required(ErrorMessage = "MP0x403: The data is required")]
    public int UnitCount { get; set; }
    [Required(ErrorMessage = "MP0x404: The data is required")]
    public decimal UnitPrice { get; set; }
}