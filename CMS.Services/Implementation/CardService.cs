using CMS.Model.Common;
using CMS.Service.Interface;
using CMS.Repository.Interface;
using Microsoft.Extensions.Configuration;

namespace CMS.Service.Implementation
{
    public class CardService : ICardService
    {
        private readonly ICardRepository _cardRepository;
        private readonly IConfiguration config;


        public CardService(ICardRepository CardRepository, IConfiguration configuration)
        {
            _cardRepository = CardRepository ?? throw new ArgumentNullException(nameof(_cardRepository));
            config = configuration;


        }
        public async Task<List<Employee>> GetAll()
        {
            IEnumerable<Employee> user;
            user = await _cardRepository.GetAll();
            return user.ToList();
        }

        public async Task<ResponseModel<bool>>AddRole(Employee employees)
        {
            bool isValidRequest = false;
            isValidRequest= await _cardRepository.AddRole(employees);
            var res = new ResponseModel<bool>();
            if (isValidRequest) 
            {
                res.IsError = !isValidRequest;
                res.Message = "Employee added successfully";
                res.Data = isValidRequest;
            }
            else
            {
                res.IsError = !isValidRequest;
                res.Message = "Error in adding the Employee";
                res.Data = isValidRequest;
            }
            return res;

        }


    }
}
