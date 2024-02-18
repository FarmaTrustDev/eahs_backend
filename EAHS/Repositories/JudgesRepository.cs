using EAHS.DTOS;
using EAHS.Interfaces;
using EAHS.Models;
using System;
using System.Linq;

namespace EAHS.Repositories
{
    public class JudgesRepository : BaseRepository<Judges>, IJudgesRepository
    {
        private readonly EAHSDbContext _cGTContext;

        public JudgesRepository(EAHSDbContext cGTContext) : base(cGTContext)
        {
            _cGTContext = cGTContext;
        }

        public JudgeResponseDTO GetById (Guid id)
        {
            return _cGTContext.Judges.Where(judg => judg.GlobalId == id && judg.Active == true)
                    .Select(judgDa => new JudgeResponseDTO()
                    {
                        Id = judgDa.Id,
                        CountryName = judgDa.CountryName,
                        GlobalId = judgDa.GlobalId,
                        IsConflict = judgDa.IsConflict,
                        IsMember = judgDa.IsMember,
                        JudgeName = judgDa.JudgeName

                    }).FirstOrDefault();
        }
        public Judges GetByGuId(Guid id)
        {
            return _cGTContext.Judges.Where(judg => judg.GlobalId == id && judg.Active == true)
                    .FirstOrDefault();
        }
    }
}
