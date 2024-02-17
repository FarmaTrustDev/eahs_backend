using EAHS.Interfaces;
using EAHS.Models;

namespace EAHS.Repositories
{
    public class RulesRepository : BaseRepository<Rules>, IRulesRepository
    {
        private readonly EAHSDbContext _cGTContext;

        public RulesRepository(EAHSDbContext cGTContext) : base(cGTContext)
        {
            _cGTContext = cGTContext;
        }
    }
}
