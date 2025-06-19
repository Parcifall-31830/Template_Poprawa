using System.Data;
using System.Globalization;
using Microsoft.Data.SqlClient;


namespace WebApplication1.Services;

public interface IDbService
{
    // public Task<ICollection<PolitykGetDto>> GetPolitycy();
    // public Task<PolitykGetDto>CreatePolityk(PolitykCreateDto polityk);
}
public class DbService(IConfiguration config):IDbService
{
   
        
}