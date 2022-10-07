using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Services
{
    public static class ServicesConfig
    {

        public static void ServiceConfiguration(IServiceCollection services)
        {
            services.AddScoped<ICategoryDal, EfCategoryRepository>();
            services.AddScoped<ICategorService, CategoryManager>();

            services.AddScoped<IBlogDal, EfBlogRepository>();
            services.AddScoped<IBlogService, BlogManager>();

            services.AddScoped<ICommentDal, EfCommentRepository>();
            services.AddScoped<ICommentService, CommentManager>();

            services.AddScoped<IWriterDal, EfWriterRepository>();
            services.AddScoped<IWriterService, WriterManager>();

            services.AddScoped<INewsLetterDal, EfNewsLetterRepository>();
            services.AddScoped<INewsLetterService, NewsLetterManager>();

            services.AddScoped<IAboutDal, EfAboutRepository>();
            services.AddScoped<IAboutService, AboutManager>();

            services.AddScoped<IContactDal, EfContactRepository>();
            services.AddScoped<IContactService, ContactManager>();

            //services.AddScoped<INotificationDal, EfNotificationRepository>();
            //services.AddScoped<INotificationService, NotificationManager>();

            //services.AddScoped<IMessageDal, EfMessageRepository>();
            //services.AddScoped<IMessageService, MessageManager>();
        }
    }
}
