using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SIS.Shared.DTOs;
using SIS.Shared.Exceptions;
using SIS.Shared.V1.Repositories;

namespace SIS.Shared.V1.Services
{
    public interface ISelectOptionService
    {
        Task<List<SelectOptionGetDTO>> GetDenominationsAsync();
        Task<List<SelectOptionGetDTO>> GetRegionsAsync();
        Task<List<SelectOptionGetDTO>> GetReligionsAsync();
    }

    public class SelectOptionService : ISelectOptionService
    {
        private readonly IDenominationRepository _denominationRepository;
        private readonly IRegionRepository _regionRepository;
        private readonly IReligionRepository _religionRepository;
        private readonly IMapper _mapper;

        public SelectOptionService(IDenominationRepository denominationRepository, IRegionRepository regionRepository, IReligionRepository religionRepository, IMapper mapper)
        {
            _denominationRepository = denominationRepository;
            _regionRepository = regionRepository;
            _religionRepository = religionRepository;
            _mapper = mapper;
        }

        public async Task<List<SelectOptionGetDTO>> GetDenominationsAsync()
        {
            var entities = await _denominationRepository
                .Query()
                .OrderBy(x => x.Name)
                .ToListAsync();
            return _mapper.Map<List<SelectOptionGetDTO>>(entities);
        }

        public async Task<List<SelectOptionGetDTO>> GetRegionsAsync()
        {
            var entities = await _regionRepository
                .Query()
                .OrderBy(x => x.Name)
                .ToListAsync();
            return _mapper.Map<List<SelectOptionGetDTO>>(entities);
        }

        public async Task<List<SelectOptionGetDTO>> GetReligionsAsync()
        {
            var entities = await _religionRepository
                .Query()
                .OrderBy(x => x.Name)
                .ToListAsync();
            return _mapper.Map<List<SelectOptionGetDTO>>(entities);
        }
    }
}
