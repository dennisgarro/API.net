using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfraEstructura.Mapper
{
    public class DataProfile : Profile
    {
        public DataProfile()
        {
            var config = new MapperConfiguration(cfg => { });
        }
    }
}
