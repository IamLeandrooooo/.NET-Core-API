using AutoMapper;
using Commander.DTO;
using Commander.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Commander.Profiles
{
    public class CommandsProfile : Profile
    {
        public CommandsProfile()
        {
            //Source, Target
            CreateMap<Commands, CommandReadDTO>();

            CreateMap<CommandCreateDTO, Commands>();

            CreateMap<CommandUpdateDTO, Commands>();

            CreateMap<Commands, CommandUpdateDTO>();
        }


    }
}
