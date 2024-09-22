using petryankin_daniil_kt_31_21.Interfaces.StudentInterfaces;
using Microsoft.Extensions.DependencyInjection;
using petryankin_daniil_kt_31_21.Interfaces.DisciplineInterfaces;

namespace petryankin_daniil_kt_31_21.ServiceExtensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IStudentService, StudentService>();
            services.AddScoped<IDisciplineService, DisciplineService>();

            return services;
        }
    }
}
