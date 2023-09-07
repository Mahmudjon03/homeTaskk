using Dapper;
using Domain.Models;
using Infracstructure.Date;
using Infracstructure.Interface;

namespace Infracstructure.Servises;

public class UserServise:IBaseServise<Users>
{
    DateContent dt=new DateContent();

    public string Add(Users t)
    {
         using var con=dt.GetConnectionString();
      var sql=$"insert into users(name,email)values('{t.name}','{t.email}')";
      var res = con.Execute(sql);
      if (res != 1){
         return "Error";
      }
      return "Orders Add";
    }

    public void Delete(int i)
    {
         using var con=dt.GetConnectionString();
        var sql=$"delete from users where id={i}";
        var res=con.Execute(sql);
    }

    public List<Users> Get()
    {
        using var con=dt.GetConnectionString();
        var sql="select * from users";
        var res =con.Query<Users>(sql).ToList();
        return res;
    }

    public Users GetById(int t)
    {
        using var con=dt.GetConnectionString();
        var sql =$"select 8 from users where id={t}";
        var res =con.QueryFirstOrDefault<Users>(sql);
        return res;
    }

    public string Update(Users t)
    {
     using var con=dt.GetConnectionString();
     var sql =$"update users set name ='{t.name}', email ='{t.email}' where id={t.id}";
     var res =con.Execute(sql);
     if(res == 1){
        return "Error";
     }
     return "User Update";
    }
}
