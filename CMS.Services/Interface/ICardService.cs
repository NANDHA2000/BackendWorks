using CMS.Model.Common;

namespace CMS.Service.Interface
{
    public interface ICardService
    {
        Task<List<Employee>> GetAll();
        Task<ResponseModel<bool>> AddRole(Employee employees);

    }
}
