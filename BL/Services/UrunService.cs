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
    public class UrunService : IUrunService
    {
        private readonly IUrunRepository _urunRepository;
        private readonly IMapper _mapper;
        public UrunService(IUrunRepository urunRepository, IMapper mapper)
        {
            _urunRepository = urunRepository;
            _mapper = mapper;
        }
        public async Task<UrunDTO> AddUrun(UrunDTO urunDto)
        {
            var urun = await _urunRepository.Add(_mapper.Map<Urun>(urunDto));
            return _mapper.Map<UrunDTO>(urun);
        }

    }
}
