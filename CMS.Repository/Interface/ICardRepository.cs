using CMS.Model.Common;

namespace CMS.Repository.Interface
{
    public interface ICardRepository
    {
        Task<IEnumerable<Employee>> GetAll();
        Task<bool> AddRole(Employee employee);


    }
}
