using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public abstract class BasePrograma
    {
        
        public BasePrograma(string nome, string telefone, string cpf)
        {
            this.Nome = nome;
            this.Telefone = telefone;
            this.CPF = cpf;
        }

        public BasePrograma() { }

        public string Nome;
        public string Telefone;
        public string CPF;

        public void SetNome(string nome) { this.Nome = nome; }
        public void SetTelefone(string telefone) { this.Telefone = telefone; }
        public void SetCPF(string cpf) { this.CPF = cpf; }

        public void gravar()
        {
            throw new NotImplementedException();
        }
    }
}
