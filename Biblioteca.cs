using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtvdBiblioteca
{
    public class Biblioteca
    {
        private List<Livro> livros = new List<Livro>();

        public void AdicionarLivro(Livro l)
        {
            livros.Add(l);
        }
        public List<Livro> ListarLivro()
        {
            return livros;
        }

        // Buscar livros por gênero
        public List<Livro> BuscarPorGenero(GeneroLivro genero)
        {
            return livros.FindAll(l => l.GetType().GetProperty("genero").GetValue(l).Equals(genero));
        }

        // Buscar livro por título
         public Livro BuscarPorTitulo(string titulo)
        {
            return livros.Find(l => string.Equals(l.Titulo, titulo, StringComparison.OrdinalIgnoreCase));
        }
    }
}