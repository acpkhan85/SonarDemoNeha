using mysql.Application.Features.Events.Queries.GetEventsExport;
using System.Collections.Generic;

namespace mysql.Application.Contracts.Infrastructure
{
    public interface ICsvExporter
    {
        byte[] ExportEventsToCsv(List<EventExportDto> eventExportDtos);
    }
}
