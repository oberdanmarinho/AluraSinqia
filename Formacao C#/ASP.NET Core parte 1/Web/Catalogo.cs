using System.Collections.Generic;

namespace Web
{
    public class Catalogo : ICatalogo
    {
        public List<Livro> GetLivros()
        {
            var livros = new List<Livro>();

            livros.Add(new Livro("001 ", "Ola mundo 01 ", 100.00m));
            livros.Add(new Livro("002 ", "Ola mundo 02 ", 140.00m));
            livros.Add(new Livro("003 ", "Ola mundo 03 ", 150.00m));

            return livros;
        }
    }
}
