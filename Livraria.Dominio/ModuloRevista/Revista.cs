using Livraria.Dominio.ModuloExemplar;

namespace Livraria.Dominio.ModuloRevista
{
    public class Revista : Exemplar
    {
        public Revista(string titulo, string autor, int numeroPaginas, string editora, DateTime dataPublicacao, string categoria) : base(titulo, autor, numeroPaginas, editora, dataPublicacao, categoria)
        {
        }
    }
}
