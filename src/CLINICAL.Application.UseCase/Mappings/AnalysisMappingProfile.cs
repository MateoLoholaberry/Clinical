﻿using AutoMapper;
using CLINICAL.Application.Dtos.Analysis.Response;
using CLINICAL.Application.UseCase.UseCases.Analysis.Commands.CreateCommand;
using CLINICAL.Application.UseCase.UseCases.Analysis.Commands.EditCommand;
using CLINICAL.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLINICAL.Application.UseCase.Mappings
{
    public class AnalysisMappingProfile : Profile
    {
        public AnalysisMappingProfile() 
        {
            CreateMap<Analysis, GetAllAnalysisResponseDto>()
                .ForMember(x => x.StateAnalysis, x => x.MapFrom(y => y.State == 1 ? "ACTIVO" : "INACTIVO"))
                .ReverseMap();


            CreateMap<Analysis, GetAnalysisByIdResponseDto>()
                .ReverseMap();

            CreateMap<CreateAnalysisCommand, Analysis>();

            CreateMap<UpdateAnalysisCommand, Analysis>();
        }
    }
}
