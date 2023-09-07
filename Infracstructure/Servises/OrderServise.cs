using Dapper;
using Domain.Models;
using Infracstructure.Date;
using Infracstructure.Interface;

namespace Infracstructure.Servises;

public class OrderServise:IBaseServise<Orders> {
   DateContent constr = new DateContent();

     public string Add(Orders t)
    {
       using var con=constr.GetConnectionString();
      var sql=$"insert into orders(user_id,product,quantity)values({t.user_id},'{t.product}',{t.quantity})";
      var res = con.ExecuteScalar(sql);
      if (res == null){
         return "Error";
      }
      return "Orders Add";
    }

    public void Delete(int i)
    {
        using var con=constr.GetConnectionString();
        var sql=$"delete from orders where id={i}";
        var res=con.Execute(sql);
    }

    public List<Orders> Get()
    {
          using var con=constr.GetConnectionString();
          var sql="select * from orders";
          var res =con.Query<Orders>(sql).ToList();
          return res;
    }

    public Orders GetById(int t)
    {
       using var con=constr.GetConnectionString();
       var sql= $"select * from orders where id={t}";
       var res = con.QueryFirstOrDefault<Orders>(sql);
       return res;
    }

    public string Update(Orders t)
    {
    using var con=constr.GetConnectionString();
    var sql=$"update orders set user_id={t.user_id},product = '{t.product}',quantity = {t.quantity} where id={t.id}";
    var res =con.Execute(sql);
    if(res != 1){
      return "Error";
     }
     return "OrdersUpdate";
    }
}

