using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database;

namespace Business
{
    public class UsuarioPrograma : BasePrograma
    {
        public UsuarioPrograma(string nome, string telefone, string cpf)
        {
            this.Nome = nome;
            this.Telefone = telefone;
            this.CPF = cpf;
        }

        public UsuarioPrograma() { }
    }
}
