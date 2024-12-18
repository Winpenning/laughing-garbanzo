using CDJ_API.Data;
using CDJ_API.Models;
using CDJ_API.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CDJ_API.Controllers;
[ApiController][Route("product")]
public class ProductController : ControllerBase{
    
    [HttpGet][Route("list")]
    public async Task<IActionResult> GetProduct
    ([FromServices] AppDataContext context){
        try{
            var products = 
                await context.Products.OrderBy(x=>x.Name).ToListAsync();
            return StatusCode(200, new ResultViewModel<List<Product>>(products));
        }catch(Exception){
            return StatusCode(500, 
                new ResultViewModel<Product>("Error CP0x101: Internal Server Error."));
        }
    }
    
    [HttpGet][Route("list/{id:int}")]
    public async Task<IActionResult> GetByIdAsync
    ([FromServices] AppDataContext context, [FromRoute] int id)
    {
        try{
            var product = 
                await context.Products.FirstOrDefaultAsync(x=>x.Id == id);
            if(product == null)
                return StatusCode(404,
                    new ResultViewModel<Product>("Error CP0X201: Product Not Found."));
            return StatusCode(200, new ResultViewModel<Product>(product));
        }catch(Exception){
            return StatusCode(500, 
                new ResultViewModel<Product>("Error CP0x202: Internal Server Error."));
        }
    }
    
    [HttpPost][Route("new")]
    public async Task<IActionResult> PostAsync
    ([FromServices] AppDataContext context, [FromBody] ProductDTO model)
    {
        try{
            Product product = new Product(
                model.Name, 
                model.UnitType, 
                model.UnitCount, 
                model.UnitPrice);
            
            await context.Products.AddAsync(product);
            await context.SaveChangesAsync();
            return StatusCode(200,
                new ResultViewModel<Product>(product));
        }catch(ArgumentException){
            return StatusCode(400, 
                new ResultViewModel<Product>("Error CP0x301: Bad Request."));
        }catch(Exception){
            return StatusCode(500,
                new ResultViewModel<Product>("Error CP0x302: Internal Server Error."));
        }
    }

    [HttpPut][Route("edit/{id:int}")]
    public async Task<IActionResult> PutAsync
    ([FromServices] AppDataContext context, [FromRoute] int id, [FromBody] ProductDTO model)
    {
        try{
            var product = await context.Products.FirstOrDefaultAsync(x=>x.Id == id);
            
            if(product == null)
                return StatusCode(404,
                    new ResultViewModel<Product>("Error CP0x401: Product Not Found."));
            
            product.Name = model.Name;
            product.UnitCount = model.UnitCount;
            product.UnitType = model.UnitType;
            product.UnitPrice = model.UnitPrice;

            context.Products.Update(product);
            await context.SaveChangesAsync();

            return StatusCode(200,
                new ResultViewModel<Product>(product));
        }catch(ArgumentException){
            return StatusCode(400, 
                new ResultViewModel<Product>("Error CP0x402: Bad Request."));
        }catch(Exception){
            return StatusCode(500,
                new ResultViewModel<Product>("Error CP0x403: Internal Server Error."));
        }
    }

    [HttpDelete][Route("deletete/{id:int}")]
    public async Task<IActionResult> DeleteAsync
    ([FromServices] AppDataContext context, [FromRoute] int id)
    {
        try{
            var product = await context.Products.FirstOrDefaultAsync(x=>x.Id == id);
            
            if(product == null)
                return StatusCode(404,
                    new ResultViewModel<Product>("Error CP0x501: Product Not Found."));
            
            context.Products.Remove(product);
            await context.SaveChangesAsync();
            return StatusCode(200,
                new ResultViewModel<Product>(product));
        }catch(Exception){
            return StatusCode(500,
                new ResultViewModel<Product>("Error CP0x502: Internal Server Error."));
        }
    }
}