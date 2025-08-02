using System.Runtime.CompilerServices;
using dapper.DataTransferModels;
using dapper.Interface;
using dapper.Services;
using Microsoft.AspNetCore.Mvc;

namespace dapper.Controllers
{
    [Route("api/Dapper")]
    [ApiController]
    public class DapperController : ControllerBase
    {
       private readonly IDapper _dapperService;

       public DapperController(IDapper Dapper) 
       {
            _dapperService = Dapper;
       }

        [HttpPost("Save")]
        public IActionResult Save(DapperVM model)
        {
            if (!ModelState.IsValid)
                return BadRequest("Bad request");

            var res = _dapperService.Save(model);
            return Ok(res);
        }

        [HttpGet("GetByEmail")]
        public IActionResult GetByEmail(string email)
        {
            if (!ModelState.IsValid)
                return BadRequest("Bad request");

            var res = _dapperService.GetByEmail(email);
            return Ok(res);
        }

        [HttpGet("GetById/{id}")]
        public IActionResult GetById(int id)
        {
            var res = _dapperService.GetById(id);
            return Ok(res);
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var res = _dapperService.GetAll();
            return Ok(res);
        }

        [HttpPut("Update/{id}")]
        public IActionResult Update(int id, DapperVM model)
        {
            if (!ModelState.IsValid)
                return BadRequest("Bad request");

            var res = _dapperService.Update(id, model);
            return Ok(res);
        }

        [HttpDelete("Delete/{id}")]
        public IActionResult Delete(int id)
        {
            var res = _dapperService.Delete(id);
            return Ok(res);
        }
    }
}
