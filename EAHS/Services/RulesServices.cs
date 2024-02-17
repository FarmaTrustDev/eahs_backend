using EAHS.Interfaces;

namespace EAHS.Services
{
    public class RulesServices
    {
        private readonly IRulesRepository _repo;
        public RulesServices(IRulesRepository repo)
        {
            _repo = repo;
        }
    }
}
