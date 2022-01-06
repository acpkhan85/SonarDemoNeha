using AutoMapper;
using mysql.Application.Features.Categories.Commands.CreateCateogry;
using mysql.Application.Features.Categories.Commands.StoredProcedure;
using mysql.Application.Features.Categories.Queries.GetCategoriesList;
using mysql.Application.Features.Categories.Queries.GetCategoriesListWithEvents;
using mysql.Application.Features.Events.Commands.CreateEvent;
using mysql.Application.Features.Events.Commands.Transaction;
using mysql.Application.Features.Events.Commands.UpdateEvent;
using mysql.Application.Features.Events.Queries.GetEventDetail;
using mysql.Application.Features.Events.Queries.GetEventsExport;
using mysql.Application.Features.Events.Queries.GetEventsList;
using mysql.Application.Features.Orders.GetOrdersForMonth;
using mysql.Domain.Entities;

namespace mysql.Application.Profiles
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {          
            CreateMap<Event, CreateEventCommand>().ReverseMap();
            CreateMap<Event, TransactionCommand>().ReverseMap();
            CreateMap<Event, UpdateEventCommand>().ReverseMap();
            CreateMap<Event, EventDetailVm>().ReverseMap();
            CreateMap<Event, CategoryEventDto>().ReverseMap();
            CreateMap<Event, EventExportDto>().ReverseMap();

            CreateMap<Category, CategoryDto>();
            CreateMap<Category, CategoryListVm>();
            CreateMap<Category, CategoryEventListVm>();
            CreateMap<Category, CreateCategoryCommand>();
            CreateMap<Category, CreateCategoryDto>();
            CreateMap<Category, StoredProcedureCommand>();
            CreateMap<Category, StoredProcedureDto>();

            CreateMap<Order, OrdersForMonthDto>();

            CreateMap<Event, EventListVm>().ConvertUsing<EventVmCustomMapper>();
        }
    }
}
