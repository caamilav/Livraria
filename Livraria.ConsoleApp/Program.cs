
using Livraria.Dominio.ModuloEbook;
using Livraria.Dominio.ModuloExemplar;
using Livraria.Dominio.ModuloLivro;
using Livraria.Dominio.ModuloRevista;

namespace Livraria.ConsoleApp
{
    internal class Program
    {
        //Camila Valdrigues Candido e Eduarda Claumann de Souza

        private static readonly List<Livro> _livros = new List<Livro>();
        private static readonly List<Revista> _revistas = new List<Revista>();
        private static readonly List<Ebook> _ebooks = new List<Ebook>();  

        static void Main(string[] args)
        {
            do
            {
                ExibirMensagem("\n\nLivraria Claumann\n", ConsoleColor.DarkCyan);

                Console.WriteLine("1 - Visualizar todos os exemplares cadastrados\n2 - Visualizar por tipo de exemplar\n3 - Cadastrar novo exemplar");
                Console.Write("Opção: ");
                var opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("\n\tVisualizar todos os exemplares cadastrados");

                        var todosExemplares = new List<Exemplar>();
                        todosExemplares.AddRange(_livros);
                        todosExemplares.AddRange(_revistas);
                        todosExemplares.AddRange(_ebooks);


                        if (todosExemplares.Count == 0)
                        {
                            ExibirMensagem("Nenhum exemplar cadastrado", ConsoleColor.Yellow);
                        }
                        else
                        {
                            foreach (var i in todosExemplares)
                            {
                                Console.WriteLine(i);
                            }
                        }

                        break;
                    case "2":
                        Console.WriteLine("\n\tVisualizar por tipo de exemplar");
                        Console.WriteLine("Informe o tipo de exemplar que deseja listar 1 - Revista | 2 - Livro | 3 - Ebook");
                        Console.Write("Tipo: ");
                        var tipoExemplar = Console.ReadLine();

                        if(tipoExemplar == "1")
                        {
                            foreach (var i in _revistas)
                            {
                                Console.WriteLine(i);
                            }
                        } else if (tipoExemplar == "2")
                        {
                            foreach (var i in _livros)
                            {
                                Console.WriteLine(i);
                            }
                        }
                        else if (tipoExemplar == "3")
                        {
                            foreach (var i in _ebooks)
                            {
                                Console.WriteLine(i);
                            }
                        } else
                        {
                            ExibirMensagem("Inválido", ConsoleColor.Red);
                        }


                        break;
                    case "3":
                        Console.WriteLine("\n\tCadastrar novo exemplar");

                        Console.WriteLine("Informe o tipo de exemplar que deseja cadastrar 1 - Revista | 2 - Livro | 3 - Ebook");
                        Console.Write("Tipo: ");
                        tipoExemplar = Console.ReadLine();

                        if (tipoExemplar != "1" && tipoExemplar != "2" && tipoExemplar != "3")
                        {
                            ExibirMensagem("Inválido", ConsoleColor.Red);
                        }
                        else
                        {
                            Console.Write("Informe o título: ");
                            string titulo = Console.ReadLine();

                            Console.Write("Informe o autor: ");
                            string autor = Console.ReadLine();

                            Console.Write("Informe o número de páginas: ");
                            int numeroPaginas = int.Parse(Console.ReadLine());

                            Console.Write("Informe a editora: ");
                            string editora = Console.ReadLine();

                            Console.Write("Informe a data de publicação no formato dd/mm/aaaa: ");
                            DateTime dataPublicacao = DateTime.Parse(Console.ReadLine());

                            Console.Write("Informe a categoria: ");
                            string categoria = Console.ReadLine();


                            if (tipoExemplar == "1")
                            {
                                var novaRevista = new Revista(titulo, autor, numeroPaginas, editora, dataPublicacao, categoria);
                                _revistas.Add(novaRevista);
                            }
                            else if (tipoExemplar == "2")
                            {
                                var novoLivro = new Livro(titulo, autor, numeroPaginas, editora, dataPublicacao, categoria);
                                _livros.Add(novoLivro);
                            }
                            else if (tipoExemplar == "3")
                            {
                                var novoEbook = new Ebook(titulo, autor, numeroPaginas, editora, dataPublicacao, categoria);
                                _ebooks.Add(novoEbook);
                            }

                            ExibirMensagem("Cadastrado com sucesso!", ConsoleColor.Green);
                        }
                        break;
                }

            } while (true);

        }


        private static void ExibirMensagem(string msg, ConsoleColor cor)
        {
            Console.ForegroundColor = cor;
            Console.WriteLine(msg);
            Console.ResetColor();
        }
    }
}
