using EAHS.DTOS;
using EAHS.Models;
using System;

namespace EAHS.Interfaces
{
    public interface IJudgesRepository : IBaseRepository<Judges>
    {
        public JudgeResponseDTO GetById(Guid id);
        public Judges GetByGuId(Guid id);
    }
}
