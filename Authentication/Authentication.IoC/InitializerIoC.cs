using Authentication.DataAccess;
using Authentication.Domain.Roles;
using Authentication.Domain.Usuarios;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Authentication.IoC
{
    public static class InitializerIoC
    {
        public static void BootDependencies(this IServiceCollection services, IConfiguration configuration) 
        {
            services.AddDbContext<AuthenticationContext>(db => db.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
            
            IdentityBuilder builder = services.AddIdentityCore<Usuario>(opt =>
            {
                opt.Password.RequireDigit = false;
                opt.Password.RequiredLength = 8;
                opt.Password.RequireNonAlphanumeric = false;
                opt.Password.RequireUppercase = false;
            });

            builder = new IdentityBuilder(builder.UserType, typeof(Role), builder.Services);
            builder.AddEntityFrameworkStores<AuthenticationContext>();
            builder.AddRoleValidator<RoleValidator<Role>>();
            builder.AddRoleManager<RoleManager<Role>>();
            builder.AddSignInManager<SignInManager<Usuario>>();
        }
    }
}
