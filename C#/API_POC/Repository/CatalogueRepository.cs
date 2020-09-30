using API_POC.Models;
using Dapper;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace API_POC.Repository
{
    public class CatalogueRepository
    {
        public List<Catalogue> GetAllCatalogues()
        {
            using (var con = new SqlConnection("Data Source=FHUNWSQRDEV11.aus.amer.dell.com;Initial Catalog=FoundationHub;Integrated Security=True"))
                //< add name = "dbnameConnectionString" connectionString = "server=.;database=dbname;uid=user;password=pass;Initial Catalog=dbname;Integrated Security= false" providerName = "System.Data.SqlClient" />

            {
                var result = con.Query<Catalogue>("select * from Catalogue").ToList();
                return result;
            }
        }

        public List<Catalogue> GetCatalogueByName(string name)
        {
            using (var con = new SqlConnection("Data Source=FHUNWSQRDEV11.aus.amer.dell.com;Initial Catalog=FoundationHub;Integrated Security=True"))
            {
                var result = con.Query<Catalogue>("select * from Catalogue where name=@name",new { name }).ToList();
                return result;
            }

        }
    }
}
