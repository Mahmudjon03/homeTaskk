namespace WEbApi.Controllers;
using Infracstructure.Servises;
using Microsoft.AspNetCore.Mvc;
using Domain.Models;

[ApiController]
[Route("[controller]")]

public class OrdersCotroller : ControllerBase 
{
    private readonly OrderServise _ors=new OrderServise();

    [HttpGet("GetOrders")]
     public List<Orders> GetOrders()=> _ors.Get();
    [HttpPost("AddOrders")]
     public string AddOrders(Orders orders) =>  _ors.Add(orders);
     [HttpPut("Update")]
     public string UpdateOrders(Orders orders) => _ors.Update(orders);
     [HttpDelete("DeleteOrders")]
     public void DeleteOrders(int ordersId)  => _ors.Delete(ordersId);
     [HttpGet("GEtById")]
     public Orders GetById(int id) => _ors.GetById(id);    
    }
