using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtvdBiblioteca
{
        public abstract class ItemBiblioteca
    {
        public string Titulo { get; set; }
        private int anoPublicacao;

        public int AnoPublicacao
        {
            get => anoPublicacao;
            set{
                if(value <0)
                {
                    throw new ArgumentException("O ano de publicacao nao pode ser menor que 0.");
                }else{
                    anoPublicacao = value;
                }
            }
        }

        public ItemBiblioteca(string titulo, int anoPublicacao)
        {
            this.Titulo = titulo;
            this.AnoPublicacao = anoPublicacao;
        }

        public abstract string ExibirDetalhes();
    }
}