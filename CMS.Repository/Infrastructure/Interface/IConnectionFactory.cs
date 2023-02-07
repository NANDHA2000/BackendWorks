using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace CMS.Repository.Infrastructure.Interface
{
    public interface IConnectionFactory : IDisposable
    {
        IDbConnection Connection { get; }
    }
}
