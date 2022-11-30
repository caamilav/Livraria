using Livraria.Dominio.ModuloExemplar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria.Dominio.ModuloEbook
{
    public class Ebook : Exemplar
    {
        public Ebook(string titulo, string autor, int numeroPaginas, string editora, DateTime dataPublicacao, string categoria) : base(titulo, autor, numeroPaginas, editora, dataPublicacao, categoria)
        {
        }
    }
}
