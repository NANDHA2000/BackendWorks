using CMS.Framework.Models.Settings;
using CMS.Model.Common;
using CMS.Repository.Infrastructure.Interface;
using CMS.Repository.Interface;
using Microsoft.Extensions.Options;

namespace CMS.Repository.Implementation
{
    public class CardsRepository : BaseRepository, ICardRepository
    {
        public CardsRepository(
            IOptions<DatabaseAdvancedSettingsOptions> settingsOptions,
                       IQueryBuilder queryBuilder,
            IUnitOfWork unitOfWork) : base(settingsOptions, queryBuilder, unitOfWork)
        {
            //_unitOfWork = unitOfWork;//
        }

        public async Task<IEnumerable<Employee>> GetAll()
        {
            return await QueryProcedureAsync<Employee>("[dbo].[usp_GetEmployees]");
        }

        public async Task<bool> AddRole(Employee employee)
        {
            var _employees = new
            {
                EmpID = employee.EmpID,
                EmpName = employee.EmpName,
                EmpPosition = employee.EmpPosition,
                EmpPlace = employee.EmpPlace,
                EmpSalary = employee.EmpSalary,
                depID = employee.depID
            };
            await QueryProcedureAsync<Employee>("[dbo].[usp_AddEmployees]", _employees);
            return true;
        }

    }
}
