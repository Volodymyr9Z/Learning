using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Chat.Application.Messages.Commands.CreateMessage;
using Chat.Application.Common.Mapping;
using AutoMapper;
using Chat.Domain;

namespace Chat.WebApi.Models
{
    public class CreateMessageDto : IMapWith<CreateMessageCommand>
    {
        public string SendingMessage { get; set; }
        public string Id { get; set; }
        public ChatUser ChatUser { get; set; }
        public DateTime SendingDate { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<CreateMessageDto, CreateMessageCommand>()
                .ForMember(messageCommand => messageCommand.ChatUser.FirstName, opt => opt.MapFrom(messageDto => messageDto.Id))
                .ForMember(messageCommand => messageCommand.ChatUser.LastName, opt => opt.MapFrom(messageDto => messageDto.ChatUser.LastName))
                .ForMember(messageCommand => messageCommand.ChatUser.FirstName, opt => opt.MapFrom(messageDto => messageDto.ChatUser.FirstName))
                .ForMember(messageCommand => messageCommand.ChatUser.UserId, opt => opt.MapFrom(messageDto => messageDto.ChatUser.UserId))
                .ForMember(messageCommand => messageCommand.SendingMessage, opt => opt.MapFrom(messageDto => messageDto.SendingMessage))
                .ForMember(messageCommand => messageCommand.SendingDate, opt => opt.MapFrom(messageDto => messageDto.SendingDate))
                .ForMember(messageCommand => messageCommand.Id, opt => opt.MapFrom(messageDto => messageDto.Id));

        }
    }
}
