namespace Infracstructure.Date;
using Npgsql;

public class DateContent
{
    string constr="Server=Localhost;Port=5432;Database=Practice;User Id=postgres;Password=mahmud04;";
    public NpgsqlConnection GetConnectionString() => new NpgsqlConnection(constr);
}
