using EAHS.Interfaces;
using EAHS.Models;

namespace EAHS.Repositories
{
    public class JudgesRepository : BaseRepository<Judges>, IJudgesRepository
    {
        private readonly EAHSDbContext _cGTContext;

        public JudgesRepository(EAHSDbContext cGTContext) : base(cGTContext)
        {
            _cGTContext = cGTContext;
        }
    }
}
