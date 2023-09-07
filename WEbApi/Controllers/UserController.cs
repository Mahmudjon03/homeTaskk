using Infracstructure.Date;
using Infracstructure.Interface;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Infracstructure.Servises;

namespace WEbApi.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController
{
   private readonly UserServise _us= new UserServise();

     [HttpPost("AddStudent")]
    public string Add(Users t) => _us.Add(t);
    
         [HttpDelete("Delete")] 
    public void Delete(int i)=> _us.Delete(i);
    [HttpGet("Get")]
     public List<Users> Get() => _us.Get();

     [HttpGet("GetById")]
    public Users GetById(int t)=>_us.GetById(t);

    
     [HttpPut("Update")]
    public string Update(Users t)=>_us.Update(t);


}
