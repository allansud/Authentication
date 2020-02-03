using Authentication.Domain.Roles;
using Authentication.Domain.UsuarioRoles;
using Authentication.Domain.Usuarios;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Authentication.DataAccess
{
    public class AuthenticationContext : IdentityDbContext<Usuario, Role, int, IdentityUserClaim<int>,
        UsuarioRole, IdentityUserLogin<int>, IdentityRoleClaim<int>, IdentityUserToken<int>>
    {
        public AuthenticationContext(DbContextOptions<AuthenticationContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
