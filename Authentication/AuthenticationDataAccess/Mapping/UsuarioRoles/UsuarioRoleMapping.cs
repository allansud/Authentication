using Authentication.Domain.UsuarioRoles;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Authentication.DataAccess.Mapping.UsuarioRoles
{
    public class UsuarioRoleMapping : EntityMappingConfiguration<UsuarioRole>
    {
        public override void Map(EntityTypeBuilder<UsuarioRole> b)
        {
            b.HasKey(u => new { u.UserId, u.RoleId });

            b.HasOne(u => u.Role).WithMany(u => u.UsuarioRoles).HasForeignKey(u => u.RoleId).IsRequired();

            b.HasOne(u => u.Usuario).WithMany(u => u.UsuarioRoles).HasForeignKey(u => u.UserId).IsRequired();
        }
    }
}
