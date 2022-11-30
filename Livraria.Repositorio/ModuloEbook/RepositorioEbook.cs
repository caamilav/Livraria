using Livraria.Dominio.ModuloEbook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria.Repositorio.ModuloEbook
{
    public class RepositorioEbook
    {
        private readonly List<Ebook> _ebooks;

        public RepositorioEbook()
        {
            _ebooks = new List<Ebook>();
        }
        public void Inserir(Ebook novoRegistro)
        {
            _ebooks.Add(novoRegistro);
        }

        public void Excluir(Ebook registro)
        {
            _ebooks.Remove(registro);
        }


        public Ebook SelecionarPorIndice(int indice)
        {
            return _ebooks[indice];
        }

        public List<Ebook> SelecionarTodos()
        {
            return _ebooks;
        }
    }
}
