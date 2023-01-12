using AutoMapper;
using BL.Services.IServices;
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
    public class FirmaService : IFirmaService
    {
        private readonly IFirmaRepository _firmaRepository;
        private readonly IMapper _mapper;
        public FirmaService(IFirmaRepository firmaRepository, IMapper mapper)
        {
            _firmaRepository = firmaRepository;
            _mapper = mapper;
        }
        public async Task<List<FirmaDTO>> GetFirmas()
        {
            var firmalar = await _firmaRepository.GetList();

            return _mapper.Map<List<FirmaDTO>>(firmalar);
        }
        public async Task<FirmaDTO> GetFirma(int userId)
        {
            var firma = await _firmaRepository.Get(x => x.Id == userId);

            if (firma is null)
            {
                throw new Exception();
            }

            return _mapper.Map<FirmaDTO>(firma);
        }

        public async Task<FirmaToAddDTO> AddFirma(FirmaToAddDTO firmaDto)
        {
            var firma = await _firmaRepository.Add(_mapper.Map<Firma>(firmaDto));
            return _mapper.Map<FirmaToAddDTO>(firma);
        }

        public async Task<FirmaDTO> UpdateFirma(FirmaDTO firmaDto)
        {
            var firma = await _firmaRepository.Get(x => x.Id == firmaDto.Id);

            if (firma is null)
            {
                throw new Exception();
            }

            firma.FirmaAdi = firmaDto.FirmaAdi;
            firma.SiparisIzinBitisSaati = firmaDto.SiparisIzinBitisSaati;

            var firmaToUpdate = _mapper.Map<Firma>(firmaDto);

            return _mapper.Map<FirmaDTO>(await _firmaRepository.Update(firmaToUpdate));
        }


    }
}

