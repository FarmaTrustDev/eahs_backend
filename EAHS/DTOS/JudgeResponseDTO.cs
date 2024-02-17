using Microsoft.AspNetCore.Http;
using System;

namespace EAHS.DTOS
{
    public class JudgeResponseDTO
    {
        public int Id { get; set; }
        public string JudgeName { get; set; }
        public string CountryFlag { get; set; }
        public string CountryName { get; set; }
        public bool IsMember { get; set; }
        public bool IsConflict { get; set; }
        public Guid GlobalId { get; set; }
    }

    public class RuleResponseDTO
    {
        public int Id { get; set; }
        public string RuleName { get; set; }
        public bool IsIncluded { get; set; }
    }
}
