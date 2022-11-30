using Livraria.Dominio.ModuloExemplar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria.Dominio.ModuloLivro
{
    public class Livro : Exemplar
    {
        public Livro(string titulo, string autor, int numeroPaginas, string editora, DateTime dataPublicacao, string categoria) : base(titulo, autor, numeroPaginas, editora, dataPublicacao, categoria)
        {
        }
    }
}
