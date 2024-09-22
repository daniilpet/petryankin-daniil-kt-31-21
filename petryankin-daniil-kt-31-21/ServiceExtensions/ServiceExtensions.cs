using petryankin_daniil_kt_31_21.Interfaces.StudentInterfaces;
using Microsoft.Extensions.DependencyInjection;

namespace petryankin_daniil_kt_31_21.ServiceExtensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IStudentService, StudentService>();

            return services;
        }
    }
}
