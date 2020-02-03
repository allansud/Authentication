using Authentication.Domain.Roles;
using Authentication.Domain.Usuarios;
using Microsoft.AspNetCore.Identity;

namespace Authentication.Domain.UsuarioRoles
{
    public class UsuarioRole : IdentityUserRole<int>
    {
        public virtual Usuario Usuario { get; set; }

        public virtual Role Role { get; set; }
    }
}
