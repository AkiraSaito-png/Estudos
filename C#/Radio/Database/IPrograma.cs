using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public interface Iprograma
    {
        void SetNome(string nome);
        void SetTelefone(string telefone);
        void SetCPF(string cpf);
        void gravar();
    }
}
