using Livraria.Dominio.ModuloLivro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria.Repositorio.ModuloLivro
{
    public class RepositorioLivro
    {
        private readonly List<Livro> _livros;

        public RepositorioLivro()
        {
            _livros = new List<Livro>();
        }
        public void Inserir(Livro novoRegistro)
        {
            _livros.Add(novoRegistro);
        }

        public void Excluir(Livro registro)
        {
            _livros.Remove(registro);
        }


        public Livro SelecionarPorIndice(int indice)
        {
            return _livros[indice];
        }

        public List<Livro> SelecionarTodos()
        {
            return _livros;
        }
    }
}
