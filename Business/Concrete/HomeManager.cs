﻿using AutoMapper;
using PersonalPortfolio.Business.Abstract;
using PersonalPortfolio.Data.Abstraction.IUnitOfWork;
using PersonalPortfolio.Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalPortfolio.Business.Concrete
{
    
    public class HomeManager : IHomePartService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public HomeManager(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<List<HomeDto>> GetAllExplanation()
        {
            var explanations = await _unitOfWork.Explanation.GetAll();
            var list = _mapper.Map<List<HomeDto>>(explanations);
            return list;
        }

        public async Task<List<HomeDto>> GetExplanationID(int id)
        {
            var a = await _unitOfWork.Explanation.GetExplanationPartPartId(id);
            var list = _mapper.Map<List<HomeDto>>(a);
            if (a.Count > 0)
            {
                return list;
            }
            else
            {
                return null;
            }
        }
    }
}
