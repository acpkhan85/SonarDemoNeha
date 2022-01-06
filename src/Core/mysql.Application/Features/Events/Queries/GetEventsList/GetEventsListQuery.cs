using mysql.Application.Responses;
using MediatR;
using System.Collections.Generic;

namespace mysql.Application.Features.Events.Queries.GetEventsList
{
    public class GetEventsListQuery: IRequest<Response<IEnumerable<EventListVm>>>
    {

    }
}
