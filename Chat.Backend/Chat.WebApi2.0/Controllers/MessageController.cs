using System.Threading.Tasks;
using Chat.Application.Messages.Commands.CreateMessage;
using Chat.Application.Messages.Commands.DeleteMessage;
using Chat.Application.Messages.Commands.EditMessage;
using Chat.Application.Messages.Queries.GetAllMessages;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using Chat.Persistence;
using Chat.Application.Interfaces;
using Chat.Application.Messages.Commands.CreateChat;

namespace Chat.WebApi2.Controllers
{
    //[Route("api/[controller]")]
    public class MessageController : BaseController
    {
        private readonly IMapper _mapper;

        public MessageController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<AllMessagesVm>> GetAll()
        {

            var query = new GetAllMessagesQuery
            {
                ChatId = ChatId
            };
            var vm = await Mediator.Send(query);
            return Ok(vm);
        }
        [HttpPost]
        public async Task<ActionResult<int>> CreateMessage([FromBody] CreateMessageCommand createMessageCommand)
        {
            var command = _mapper.Map<CreateMessageCommand>(createMessageCommand);
            var messageId = await Mediator.Send(command);

            return Ok(messageId);
        }

        [HttpPut]
        public async Task<ActionResult> EditMessage([FromBody] EditMessageCommand editMessageCommand)
        {
            var command = _mapper.Map<EditMessageCommand>(editMessageCommand);
            await Mediator.Send(command);

            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteMessage(int id)
        {
            var command = new DeleteMessageCommand
            {
                Id = id
            };
            await Mediator.Send(command);
            return NoContent();
        }

        public async Task<ActionResult<int>> CreateChat([FromBody] CreateChatCommand createChatCommand)
        {
            var command = _mapper.Map<CreateChatCommand>(createChatCommand);
            var chatId = await Mediator.Send(command);

            return Ok(chatId);

        }
        public IActionResult Index()
        {
            return View();
        }

    }
}
