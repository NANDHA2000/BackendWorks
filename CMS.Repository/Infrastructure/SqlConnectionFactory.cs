using CMS.Framework.Models.Settings;
using CMS.Repository.Infrastructure.Interface;
using Microsoft.Extensions.Options;
using System.Data;
using System.Data.SqlClient;

namespace CMS.Repository.Infrastructure
{
    public sealed class SqlConnectionFactory : IConnectionFactory
    {
        private bool isDisposed = false;
        private readonly string azureConnectionString;
        private readonly string appSettingsconnectionString;
        public SqlConnectionFactory(IOptions<DatabaseAdvancedSettingsOptions> options)
        {
            appSettingsconnectionString = options.Value.DatabaseConnectionString;
        }
        //Update here whwn you connect with KeyVault
        public IDbConnection Connection =>  new SqlConnection(appSettingsconnectionString);

        public void Dispose()
        {
            if (!isDisposed)
            {
                Connection?.Dispose();
                isDisposed = true;
            }
        }
    }
}
