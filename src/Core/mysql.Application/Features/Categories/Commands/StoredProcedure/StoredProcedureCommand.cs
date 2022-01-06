using mysql.Application.Responses;
using MediatR;

namespace mysql.Application.Features.Categories.Commands.StoredProcedure
{
    public class StoredProcedureCommand: IRequest<Response<StoredProcedureDto>>
    {
        public string Name { get; set; }
    }
}
