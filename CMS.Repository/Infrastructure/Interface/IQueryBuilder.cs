using System;
using System.Collections.Generic;
using System.Text;

namespace CMS.Repository.Infrastructure.Interface
{
    public interface IQueryBuilder
    {
        string GetAllQuery(string tablename);
    }
}
