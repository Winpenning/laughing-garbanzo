using CDJ_API.Data;
using CDJ_API.Models;
using CDJ_API.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CDJ_API.Controllers;

[ApiController][Route("custumer")]
public class CustumerController : ControllerBase{

    [HttpGet][Route("list")]
    public async Task<IActionResult> GetCustumer
    ([FromServices] AppDataContext context)
    {
        try{
            var custumers = 
                await context.Custumers.OrderBy(x=>x.FirstName).ToListAsync();
            return StatusCode(200, new ResultViewModel<List<Custumer>>(custumers));
        }catch(Exception){
            return StatusCode(500, 
            new ResultViewModel<CustumerDTO>("Error CC0x202: Internal Server Error."));
        }
    }
    
    [HttpPost][Route("new")]
    public async Task<IActionResult> PostCustumer
    ([FromServices] AppDataContext context, [FromBody] CustumerDTO model)
    {
        try{
            Custumer custumer = new Custumer(
                model.FirstName,
                model.LastName,
                model.PhoneNumber,
                model.BirthdayDate);

            await context.Custumers.AddAsync(custumer);
            await context.SaveChangesAsync();
            return StatusCode(200, 
            new ResultViewModel<CustumerDTO>(model));   
        }catch(ArgumentException){
            return StatusCode(400, 
            new ResultViewModel<CustumerDTO>("Error CC0x101: Bad Request."));
        }
        catch(Exception){
            return StatusCode(500, 
            new ResultViewModel<CustumerDTO>("Error CC0x102: Internal Server Error."));
        }
    }

    [HttpPut][Route("{id:int}")]
    public async Task<IActionResult> PutAsync
    ([FromServices] AppDataContext context, [FromRoute] int id, [FromBody] CustumerDTO model)
    {
        try{
            var custumer = 
                await context.Custumers.FirstOrDefaultAsync(x=>x.Id == id);
            
            if(custumer == null)
                return StatusCode(404, new ResultViewModel<Custumer>("Error CC0x301: Custumer Not Found."));
            
            custumer.FirstName = model.FirstName;
            custumer.LastName = model.LastName;
            custumer.PhoneNumber = model.PhoneNumber;
            custumer.BirthdayDate = model.BirthdayDate;

            context.Custumers.Update(custumer);
            await context.SaveChangesAsync();            

            return StatusCode(200, 
            new ResultViewModel<Custumer>(custumer));
        }
        catch(ArgumentException){
            return StatusCode(400, 
            new ResultViewModel<CustumerDTO>("Error CC0x303: Bad Request."));
        }catch(Exception){
            return StatusCode(500, 
            new ResultViewModel<Custumer>("Error CC0x302: Internal Server Error."));
        }
    }
}