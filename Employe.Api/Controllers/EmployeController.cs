using Employe.Business.Interfaces;
using Employe.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Employe.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeController : ControllerBase
    {
        private readonly IEmployeService _employeService;

        public EmployeController(IEmployeService employeService)
        {
            _employeService = employeService;
        }

        [HttpGet]
        [Route("ListEmploye")]
        public async Task<IEnumerable<EmployeTable>> GetEmploye()
        {
            return await _employeService.ListEmploye();
        }

        [HttpPost]
        [Route("CreateEmploye")]
        public async Task<IActionResult> CreateEmploye([FromBody] EmployeTable employe)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            await _employeService.CreateEmploye(employe);
            return CreatedAtAction(nameof(GetEmploye), new {id = employe.EmployeId}, employe);
        }
    }
}
