using Livraria.Dominio.ModuloRevista;

namespace Livraria.Repositorio.ModuloRevista
{
    public class RepositorioRevista
    {
        private readonly List<Revista> _revistas;

        public RepositorioRevista()
        {
            _revistas = new List<Revista>();
        }
        public void Inserir(Revista novoRegistro)
        {
            _revistas.Add(novoRegistro);
        }

        public void Excluir(Revista registro)
        {
            _revistas.Remove(registro);
        }


        public Revista SelecionarPorIndice(int indice)
        {
            return _revistas[indice];
        }

        public List<Revista> SelecionarTodos()
        {
            return _revistas;
        }
    }
}
