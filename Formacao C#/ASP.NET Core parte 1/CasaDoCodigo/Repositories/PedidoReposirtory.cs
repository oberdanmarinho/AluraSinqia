using Microsoft.AspNetCore.Http;
using static CasaDoCodigo.Models.Produto;

namespace CasaDoCodigo.Repositories
{
    public interface IPedidoRepository
    {
    }

    public class PedidoRepository : BaseRepository<Pedido>, IPedidoRepository
    {
        private readonly IHttpContextAccessor contextAcessor;
        public PedidoRepository(ApplicationContext contexto,
            IHttpContextAccessor contextAccessor) : base(contexto)
        {
            this,.contextAcessor = contextAccessor;
        }

        private int? GetPedidoId()
        {
            return contextAcessor.HttpContext.Session.GetInt32("pedidoId");
        }

        private void SetPedidoId(int pedidoId)
        {
            contextAcessor.HttpContext.Session.SetInt32("pedidoId", pedidoId);
        }
    }
}
