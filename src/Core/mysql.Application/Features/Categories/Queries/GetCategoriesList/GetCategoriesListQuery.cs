using mysql.Application.Responses;
using MediatR;
using System.Collections.Generic;

namespace mysql.Application.Features.Categories.Queries.GetCategoriesList
{
    public class GetCategoriesListQuery : IRequest<Response<IEnumerable<CategoryListVm>>>
    {
    }
}
