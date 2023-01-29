using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportViewerDotNet
{
    public class Clientes : IDisposable
    {
        public int? Id { get; set; }
        public string Nome { get; set; }
        public string Nascimento { get; set; }

        public Clientes(int id, string nome, string nascimento) 
        { 
            Id = id;
            Nome = nome;
            Nascimento = nascimento;
        }

        public void Dispose()
        {
            Id = null;
            Nome = null;
            Nascimento = null;
        }
    }
}
