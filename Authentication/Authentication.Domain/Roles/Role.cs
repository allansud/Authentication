using Authentication.Domain.UsuarioRoles;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Authentication.Domain.Roles
{
    public class Role : IdentityRole<int>
    {
        public virtual ICollection<UsuarioRole> UsuarioRoles { get; set; }
    }
}
