using System;
using MediatR;
using System.Collections.Generic;

namespace GloboTicket.TicketManagement.Application.Features.Categories.Queries.GetCategoryList
{
    public class GetCategoryListQuery : IRequest<List<CategoryListVm>>
    {

    }
}
