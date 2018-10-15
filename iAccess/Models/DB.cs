using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.Entity.Core.EntityClient;

namespace iAccess.Models
{
    public partial class DB : DbContext
    {
        
        public string GenerateConnectionStringEntity(string connEntity)
        {
            // Initialize the SqlConnectionStringBuilder.  
            string dbServer = string.Empty;
            string dbName = string.Empty;
            // use it from previously built normal connection string  
            Helper my = new Helper();
            string connectString = my.getConnectionString();
            var sqlBuilder = new SqlConnectionStringBuilder(connectString);
            // Set the properties for the data source.  
            dbServer = sqlBuilder.DataSource;
            dbName = sqlBuilder.InitialCatalog;
            //sqlBuilder.UserID = "Database_User_ID";
            //sqlBuilder.Password = "Database_User_Password";
            sqlBuilder.IntegratedSecurity = false;
            sqlBuilder.MultipleActiveResultSets = true;
            // Build the SqlConnection connection string.  
            string providerString = Convert.ToString(sqlBuilder);
            // Initialize the EntityConnectionStringBuilder.  
            var entityBuilder = new EntityConnectionStringBuilder();
            //Set the provider name.  
            entityBuilder.Provider = "System.Data.SqlClient";
            // Set the provider-specific connection string.  
            entityBuilder.ProviderConnectionString = providerString;
            // Set the Metadata location.  
            entityBuilder.Metadata = @"res://*/Models.WFMP.csdl|  
            res: //*/Models.WFMP.ssdl|  
            res: //*/Models.WFMP.msl";  
            return entityBuilder.ToString();
        }


    }
}