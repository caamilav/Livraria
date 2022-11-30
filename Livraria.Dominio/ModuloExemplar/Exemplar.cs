namespace Livraria.Dominio.ModuloExemplar
{
    public class Exemplar
    {
        public Exemplar(string titulo, string autor, int numeroPaginas, string editora, DateTime dataPublicacao, string categoria)
        {
            Titulo = titulo;
            Autor = autor;
            NumeroPaginas = numeroPaginas;
            Editora = editora;
            DataPublicacao = dataPublicacao;
            Categoria = categoria;
        }

        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int NumeroPaginas { get; set; }
        public string Editora { get; set; }
        public DateTime DataPublicacao { get; set; }
        public string Categoria { get; set; }


        public override string ToString()
        {
            return $"Título: {Titulo}\nAutor: {Autor}\nNº páginas: {NumeroPaginas}\nEditora: {Editora}\nData de publicação: {DataPublicacao.ToShortDateString()}\nCategoria: {Categoria}\n\n";
        }
    }
}
