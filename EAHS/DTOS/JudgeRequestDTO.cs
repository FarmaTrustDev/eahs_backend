using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace EAHS.DTOS
{
    public class JudgeRequestDTO
    {
        public string JudgeName { get; set; }
        public IFormFile CountryFlag { get; set; }
        public string CountryName { get; set; }
        public bool IsMember { get; set; }
        public bool IsConflict { get; set; }
    }
    public class RuleRequestDTO
    {
        public List<int> Rules { get; set; }
    }
}
