using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Chat.Application.Common.Mapping;
using Chat.Domain;

namespace Chat.Application.Messages.Queries.GetAllMessages
{
    public class MessageLookUpDto : IMapWith<Message>
    {
        public ChatUser ChatUser { get; set; }
        public int Id { get; set; }
        
        public string SendingMessage { get; set; }
        public DateTime SendingDate { get; set; }
        public DateTime? EditDate { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<Message, MessageLookUpDto>()
                .ForPath(noteVm => noteVm.ChatUser.FirstName, opt => opt.MapFrom(note => note.ChatUser.FirstName))
                .ForPath(noteVm => noteVm.ChatUser.LastName, opt => opt.MapFrom(note => note.ChatUser.LastName))
                .ForMember(noteVm => noteVm.SendingDate, opt => opt.MapFrom(note => note.SendingDate))
                .ForMember(noteVm => noteVm.SendingMessage, opt => opt.MapFrom(note => note.SendingMessage))
                .ForMember(noteVm => noteVm.Id, opt => opt.MapFrom(note => note.Id))
                .ForMember(noteVm => noteVm.EditDate, opt => opt.MapFrom(note => note.EditDate))
                .ForPath(noteVm => noteVm.ChatUser.UserId, opt => opt.MapFrom(note => note.ChatUser.UserId));
        }
    }
}
