using AutoMapper;
using BL.Services.IServices;
using DAL.Repository;
using DAL.Repository.IRepositories;
using DTO.DTOs;
using EL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Services
{
    public class SiparisService : ISiparisService
    {
        private readonly ISiparisRepository _siparisRepository;
        private readonly IMapper _mapper;
        public SiparisService(ISiparisRepository siparisRepository, IMapper mapper)
        {
            _siparisRepository = siparisRepository;
            _mapper = mapper;
        }

        public async Task<SiparisDTO> AddSiparis(SiparisDTO siparisDto)
        {
            var addedSiparis = await _siparisRepository.Add(_mapper.Map<Siparis>(siparisDto));
            return _mapper.Map<SiparisDTO>(addedSiparis);
        }
    }
}
