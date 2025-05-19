
using AtvdBiblioteca;

public class Program
{

    public static void Main()
    {
        // Criar uma biblioteca
        Biblioteca biblioteca = new Biblioteca();

        // Adicionar 3 livros à biblioteca
        Livro livro1 = new Livro("O Senhor dos Anéis", 1954, GeneroLivro.FANTASIA, "J.R.R. Tolkien", true);
        Livro livro2 = new Livro("Fundação", 1951, GeneroLivro.FICCAO, "Isaac Asimov", false);
        Livro livro3 = new Livro("Cálculo", 2010, GeneroLivro.TECNICO, "James Stewart", true);

        biblioteca.AdicionarLivro(livro1);
        biblioteca.AdicionarLivro(livro2);
        biblioteca.AdicionarLivro(livro3);

        // Exibir detalhes dos livros
        Console.WriteLine("Detalhes completos dos livros:");
        foreach (var livro in biblioteca.ListarLivro())
        {
            Console.WriteLine(livro.ExibirDetalhes());
        }



        // Exibir detalhes resumidos dos livros
        Console.WriteLine("\nDetalhes resumidos dos livros:");
        foreach (var livro in biblioteca.ListarLivro())
        {
            Console.WriteLine(livro.ExibirDetalhes(true));
        }

        // Buscar livros por gênero FICCAO
        Console.WriteLine("\nLivros do gênero FICCAO:");
        foreach (var livro in biblioteca.BuscarPorGenero(GeneroLivro.FICCAO))
        {
            Console.WriteLine(livro.ExibirDetalhes());
        }

        // Buscar um livro por título e exibir detalhes
        string tituloBusca = "Fundação";
        Console.WriteLine($"\nBusca pelo livro com título '{tituloBusca}':");
        var livroBuscado = biblioteca.BuscarPorTitulo(tituloBusca);
        if (livroBuscado != null)
        {
            Console.WriteLine(livroBuscado.ExibirDetalhes());
        }
        else
        {
            Console.WriteLine("Livro não encontrado.");
        }
    }

}