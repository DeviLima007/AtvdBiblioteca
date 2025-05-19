using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace AtvdBiblioteca
{
    public class Livro : ItemBiblioteca, Emprestavel
    {
        private GeneroLivro genero;
        private string autor;
        private bool estaDisponivel;
        private int codigo;
        private static int ultimoCodigo = 1;

        public Livro(string titulo, int anoPublicacao, GeneroLivro genero, string autor, bool estaDisponivel):base(titulo, anoPublicacao){
            this.genero = genero;
            this.autor = autor;
            this.estaDisponivel = estaDisponivel;
            ultimoCodigo++;
            this.codigo = ultimoCodigo;
        }

        public override string ExibirDetalhes()
        {
            return $"{Titulo} - {autor} - {genero} - {AnoPublicacao} - {(estaDisponivel? "Disponível" : "Indisponível")}";
        }

        public string ExibirDetalhes(bool resumido)
        {
            if(resumido == true)
            {
                return $"{Titulo} - {AnoPublicacao}";
            }
            return ExibirDetalhes();
        }

        public bool PodeSerEmprestado()
        {
            return estaDisponivel;
        }

    }
}