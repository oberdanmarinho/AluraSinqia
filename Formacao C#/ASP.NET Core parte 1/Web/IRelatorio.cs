using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace Web
{
    public interface IRelatorio
    {
        Task Imprimir(HttpContext context);
    }
}