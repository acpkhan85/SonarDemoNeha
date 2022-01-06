using mysql.Application.Responses;
using MediatR;

namespace mysql.Application.Features.Categories.Commands.CreateCateogry
{
    public class CreateCategoryCommand: IRequest<Response<CreateCategoryDto>>
    {
        public string Name { get; set; }
    }
}
