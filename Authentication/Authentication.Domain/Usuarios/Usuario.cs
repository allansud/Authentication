using Authentication.Domain.UsuarioRoles;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Authentication.Domain.Usuarios
{
    public class Usuario : IdentityUser<int>
    {
        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        public string Senha { get; set; }

        public DateTime DataCadastro { get; set; }

        public DateTime DataNascimento { get; set; }

        public DateTime UltimaAtividade { get; set; }

        public string PhotoUrl { get; set; }

        public string Sexo { get; set; }

        public string ConhecidoComo { get; set; }

        public string SobreVoce { get; set; }

        public string ProcurandoPor { get; set; }

        public string Interesses { get; set; }

        public string Cidade { get; set; }

        /* País */
        public string Pais { get; set; }

        public virtual ICollection<UsuarioRole> UsuarioRoles { get; set; }
    }
}
