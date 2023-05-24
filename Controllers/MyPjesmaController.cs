using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;
using VirtualDj.Dtos.DTOPjesma;
using VirtualDj.Models;
using VirtualDj.Services;

namespace VirtualDj.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyPjesmaController : ControllerBase
    {
        private readonly IPjesmaService _pjesmaService;

        public MyPjesmaController(IPjesmaService pjesmaService)
        {
            _pjesmaService = pjesmaService;
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<ServiceResponse<List<GetPjesmaDto>>>> GetAll() {
            return Ok(await _pjesmaService.GetAll());
        }

        [HttpGet("GetId")]
        public async Task<ActionResult<ServiceResponse<GetPjesmaDto>>> GetById(int id)
        {
            return Ok(await _pjesmaService.GetById(id));
        }

        [HttpGet("GetString")]
        public async Task<ActionResult<ServiceResponse<GetPjesmaDto>>> GetByString(string name)
        {
            return Ok(await _pjesmaService.GetByName(name));
        }

        [HttpPost("AddCharacter")]
        public async Task<ActionResult<ServiceResponse<List<GetPjesmaDto>>>> AddPjesma(AddPjesmaDto newpjesma)
        {
            var odgovor = (await _pjesmaService.AddPjesma(newpjesma));
            if (odgovor == null)
            {
                return NotFound(odgovor);
            }
            else
                return Ok(odgovor);
        }

        [HttpPut("UpdatePjesma")]
        public async Task<ActionResult<ServiceResponse<GetPjesmaDto>>> UpdatePjesma(UpdatePjesmaDto updatedpjesma) {
            return Ok(await _pjesmaService.UpdatePjesma(updatedpjesma));
        }

        [HttpDelete("DeletePjesma")]
        public async Task<ActionResult<ServiceResponse<List<GetPjesmaDto>>>> DeletePjesma(int id) {
            var odgovor = (await _pjesmaService.DeletePjesma(id));
            if (odgovor == null)
            {
                return NotFound(odgovor);
            }
            else
                return Ok(odgovor);
        }
    }
}
