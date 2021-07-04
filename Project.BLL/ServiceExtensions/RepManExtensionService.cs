using Microsoft.Extensions.DependencyInjection;
using Project.BLL.ManagerServices.Abstracts;
using Project.BLL.ManagerServices.Concretes;
using Project.DAL.Repositories.Abstracts;
using Project.DAL.Repositories.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.BLL.ServiceExtensions
{
    public static class RepManExtensionService
    {
        public static IServiceCollection AddRepManServices(this IServiceCollection services)
        {

            //Repositories
            services.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
            services.AddScoped<IAuthorRepository, AuthorRepository>();
            services.AddScoped<IGenreRepository, GenreRepository>();
            services.AddScoped<IRoomRepository, RoomRepository>();
            services.AddScoped<IShelfRepository, ShelfRepository>();
            services.AddScoped<IBookRepository, BookRepository>();

            //Managers

            services.AddScoped(typeof(IManager<>), typeof(BaseManager<>));
            services.AddScoped<IAuthorManager, AuthorManager>();
            services.AddScoped<IGenreManager, GenreManager>();
            services.AddScoped<IRoomManager, RoomManager>();
            services.AddScoped<IShelfManager, ShelfManager>();
            services.AddScoped<IBookManager, BookManager>();

            return services;
        }
    }
}
