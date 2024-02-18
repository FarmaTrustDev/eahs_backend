using EAHS.Interfaces;
using EAHS.Models;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace EAHS.Repositories
{
    public class RulesRepository : BaseRepository<Rules>, IRulesRepository
    {
        private readonly EAHSDbContext _cGTContext;

        public RulesRepository(EAHSDbContext cGTContext) : base(cGTContext)
        {
            _cGTContext = cGTContext;
        }
        public Rules GetById(int id)
        {
            return _cGTContext.Rules.Where(rul=>rul.Id ==  id).FirstOrDefault();
        }
    }
}
