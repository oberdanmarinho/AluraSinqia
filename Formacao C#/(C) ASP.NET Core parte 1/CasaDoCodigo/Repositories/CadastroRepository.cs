using static CasaDoCodigo.Models.Produto;

namespace CasaDoCodigo.Repositories
{
    public interface ICadastroRepository
    {

    }

    public class CadastroRepository : BaseRepository<Cadastro>, ICadastroRepository
    {
        public CadastroRepository(ApplicationContext contexto) : base(contexto)
        {
        }
    }
}
