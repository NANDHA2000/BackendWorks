using CMS.Repository.Infrastructure.Interface;

namespace CMS.Repository.Infrastructure
{
    public class SqlQueryBuilder : IQueryBuilder
    {
        public string GetAllQuery(string tablename)
        {
            return $"select * from{tablename}";
        }
    }
}
