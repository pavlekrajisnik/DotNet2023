using Microsoft.AspNetCore.Mvc;
using VirtualDj.Dtos.DTOPjesma;
using VirtualDj.Models;

namespace VirtualDj.Services
{
    public interface IPjesmaService
    {
        Task<ServiceResponse<List<GetPjesmaDto>>> GetAll();
        Task<ServiceResponse<GetPjesmaDto>> GetById(int id);
        Task<ServiceResponse<GetPjesmaDto>> GetByName(string name);
        Task<ServiceResponse<List<GetPjesmaDto>>> AddPjesma(AddPjesmaDto newpjesma);
        Task<ServiceResponse<GetPjesmaDto>> UpdatePjesma(UpdatePjesmaDto updatePjesma);
        Task<ServiceResponse<List<GetPjesmaDto>>> DeletePjesma(int id);
    }
}
