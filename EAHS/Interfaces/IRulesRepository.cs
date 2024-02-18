using EAHS.Models;
using System.Threading.Tasks;

namespace EAHS.Interfaces
{
    public interface IRulesRepository : IBaseRepository<Rules>
    {
        public Rules GetById(int id);
    }
}
