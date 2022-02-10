using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Chat.Application.Messages.Commands.EditMessage;
using Chat.Application.Common.Mapping;
using AutoMapper;

namespace Chat.WebApi.Models
{
    public class EditMessageDto :IMapWith<EditMessageCommand>
    {
        public string SendingMessage { get; set; }
        public int Id { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<EditMessageDto, EditMessageCommand>()
                .ForMember(messageCommand => messageCommand.Id, opt => opt.MapFrom(messageDto => messageDto.Id))
                .ForMember(messageCommand => messageCommand.SendingMessage, opt => opt.MapFrom(messageDto => messageDto.SendingMessage));
        }
    }
}
