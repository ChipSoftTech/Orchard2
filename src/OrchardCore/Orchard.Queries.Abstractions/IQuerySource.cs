using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace Orchard.Queries
{
    public interface IQuerySource
    {
        string Name { get; }
        Query Create();
        Task<JToken> ExecuteQueryAsync(Query query);
    }
}
