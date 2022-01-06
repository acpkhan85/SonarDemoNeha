using MediatR;

namespace mysql.Application.Features.Events.Queries.GetEventsExport
{
    public class GetEventsExportQuery: IRequest<EventExportFileVm>
    {
    }
}
