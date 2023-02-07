using CMS.Model.Common;
using CMS.Service.Implementation;
using CMS.Service.Interface;
using Microsoft.AspNetCore.Mvc;

namespace UnitOfWorkExampleProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CMSController : ControllerBase
    {
        private readonly ICardService _cardService;
        public CMSController(ICardService CardService)
        {
            _cardService = CardService ?? throw new ArgumentNullException(nameof(CardService));
        }

        [Route("Roles")]
        [HttpGet]
        public async Task<ActionResult<List<Employee>>> GetAll()
        {
            return await _cardService.GetAll();
        }

        [Route("AddRoles")]
        [HttpPost]
        public async Task<ActionResult<ResponseModel<bool>>> AddRole([FromForm] Employee employee)
        {
            return await _cardService.AddRole(employee);
        }
    }
}
