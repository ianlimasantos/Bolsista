using AutoMapper;
using Bolsista.Application.ViewModel;
using Bolsista.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolsista.Application.Mapper
{
    public class DomainToViewProfile : Profile
    {
        public DomainToViewProfile() 
        {
            CreateMap<PessoaBolsista, PessoaBolsistaViewModel>();
        }
    }
}
