using EAHS.DTOS;
using EAHS.Interfaces;
using EAHS.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EAHS.Services
{
    public class RulesServices
    {
        private readonly IRulesRepository _repo;
        public RulesServices(IRulesRepository repo)
        {
            _repo = repo;
        }
        public List<RuleResponseDTO> GetAll()
        {
            List<RuleResponseDTO> listRuleDTOs = new List<RuleResponseDTO>();
            List<Rules> rules = _repo.Get().Where(jug => jug.Active == true).ToList();
            foreach (Rules rul in rules)
            {
                RuleResponseDTO rulResponseDTO = new RuleResponseDTO();
                rulResponseDTO.Id = rul.Id;
                rulResponseDTO.IsIncluded = rul.IsIncluded;
                rulResponseDTO.RuleName = rul.RuleName;
                listRuleDTOs.Add(rulResponseDTO);
            }
            return listRuleDTOs;
        }
        public Rules GetById(int id)
        {
            return _repo.GetById(id);
        }
        public async Task<bool> Update(List<RuleRequestDTO> request)
        {
            foreach(var item in request)
            {
                var ruleData = _repo.GetById(item.Id);
                if (ruleData != null)
                {
                    ruleData.IsIncluded = item.IsIncluded;
                    ruleData.UpdatedAt = System.DateTime.Now;
                    await _repo.Update(ruleData);
                }
            }
            return true;
        }
    }
}
