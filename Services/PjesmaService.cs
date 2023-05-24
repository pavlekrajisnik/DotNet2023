using Microsoft.AspNetCore.Http.HttpResults;
using VirtualDj.Data;
using VirtualDj.Dtos.DTOPjesma;
using VirtualDj.Models;

namespace VirtualDj.Services
{
    public class PjesmaService : IPjesmaService
    {
        public List<Pjesma> Pjesme = new List<Pjesma>() {
            new Pjesma(),
            new Pjesma{ Id = 2 , NazivPjesme = "99" , Izvodjac = "Jala brat" ,Trending = 2 , Tip = Zanr.RnB},
            new Pjesma{Id = 3 , NazivPjesme = "Devojka iz grada", Izvodjac = "Miroslav Ilic", Trending = 4 ,Tip = Zanr.Narodna },
            new Pjesma{Id = 4 ,NazivPjesme = "River" , Izvodjac  = "Eminem & Ed Sheeran" , Trending = 1, Tip = Zanr.Pop },
            new Pjesma{Id = 5 , NazivPjesme = "Leptiricu sarenicu" , Izvodjac = "Kolibri" , Trending = 5, Tip = Zanr.Djecija}
        };
        private readonly IMapper _mapper;
        private readonly DataContext _context;

        public PjesmaService(IMapper mapper ,DataContext context)
        {
            _mapper = mapper;
            _context = context;
        }


        public async Task<ServiceResponse<List<GetPjesmaDto>>> GetAll()
        {
            var Service_Response = new ServiceResponse<List<GetPjesmaDto>>();
            var dbPjesme = await _context.Pjesme.ToListAsync();
            Service_Response.Data = dbPjesme.Select(c => _mapper.Map<GetPjesmaDto>(c)).ToList();
            return Service_Response;
        }

        public async Task<ServiceResponse<GetPjesmaDto>> GetById(int id)
        {
            var Service_Response = new ServiceResponse<GetPjesmaDto>();
            var dbPjesma = await _context.Pjesme.FirstOrDefaultAsync(c => c.Id == id);
            Service_Response.Data = _mapper.Map<GetPjesmaDto>(dbPjesma);
            return Service_Response;
        }

        public async Task<ServiceResponse<GetPjesmaDto>> GetByName(string name)
        {
            var Service_Response = new ServiceResponse<GetPjesmaDto>();
            var dbPjesma =  await _context.Pjesme.FirstOrDefaultAsync(c => c.NazivPjesme == name);
            Service_Response.Data = _mapper.Map<GetPjesmaDto>(dbPjesma);
            return Service_Response;
        }

        public async Task<ServiceResponse<List<GetPjesmaDto>>> AddPjesma(AddPjesmaDto newpjesma)
        {
            var Service_Response = new ServiceResponse<List<GetPjesmaDto>>();
            var pjesma = _mapper.Map<Pjesma>(newpjesma);
            _context.Pjesme.Add(pjesma);
            await _context.SaveChangesAsync();
            Service_Response.Data = await _context.Pjesme.Select(c => _mapper.Map<GetPjesmaDto>(c)).ToListAsync();
            return Service_Response;

        }

        public async Task<ServiceResponse<GetPjesmaDto>> UpdatePjesma(UpdatePjesmaDto updatedPjesma)
        {
            var Service_Response = new ServiceResponse<GetPjesmaDto>();
            try { 
            var pjesma =  await _context.Pjesme.FirstOrDefaultAsync(c => c.Id == updatedPjesma.Id);
                if (pjesma == null) {
                    throw new Exception($"Pjesma sa ovim brojem nije pronadjena");
                }
            
                _mapper.Map<Pjesma>(updatedPjesma);
                pjesma.NazivPjesme = updatedPjesma.NazivPjesme;
                pjesma.Tip = updatedPjesma.Tip;
                pjesma.Trending = updatedPjesma.Trending;
                pjesma.Izvodjac = updatedPjesma.Izvodjac;
                await _context.SaveChangesAsync();
                Service_Response.Data = _mapper.Map<GetPjesmaDto>(pjesma);
            }
            catch(Exception ex)
            {
                Service_Response.Profesija = false;
            }
            return Service_Response;
            
        }

        public async Task<ServiceResponse<List<GetPjesmaDto>>> DeletePjesma(int id)
        {
            var Service_Response = new ServiceResponse<List<GetPjesmaDto>>();
            
            var pjesma =  await _context.Pjesme.FirstOrDefaultAsync(c =>c.Id == id);
             _context.Pjesme.Remove(pjesma);
            await _context.SaveChangesAsync();
            Service_Response.Data = await _context.Pjesme.Select(c => _mapper.Map<GetPjesmaDto>(c)).ToListAsync();
            return Service_Response;
        }
    }
}
