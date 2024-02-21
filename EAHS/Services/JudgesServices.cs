using EAHS.DTOS;
using EAHS.Helper;
using EAHS.Helper.ExceptionHendling;
using EAHS.Interfaces;
using EAHS.Models;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EAHS.Services
{
    public class JudgesServices
    {
        private readonly IJudgesRepository _repo;
        private readonly ICountryRepository _countryRepository;
        private readonly string QR_STROAGE_PATH = "/user/";
        public JudgesServices(IJudgesRepository repo, ICountryRepository countryRepository)
        {
            _repo = repo;
            _countryRepository = countryRepository;
        }
        public async Task<JudgeResponseDTO> CreateJudge(JudgeRequestDTO request)
        {
            try
            {
                Judges judges = new Judges()
                {
                    JudgeName = request.JudgeName,
                    CountryName = request.CountryName,
                    IsConflict = request.IsConflict,
                    IsMember = request.IsMember,
                    CreatedAt = System.DateTime.Now,
                    Active = true,
                };
                Judges newJudge = _repo.Create(judges).Result;
     
                if (newJudge != null)
                {
                    JudgeResponseDTO judgeResponseDTO = new JudgeResponseDTO()
                    {
                        Id = newJudge.Id,
                        JudgeName = newJudge.JudgeName,
                        CountryName = newJudge.CountryName,
                        IsMember = newJudge.IsMember,
                        IsConflict=newJudge.IsConflict,
                        CountryFlag = newJudge.CountryFlag,
                    };
                    return judgeResponseDTO;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new ApiException(ex.Message);
            }

        }
        public List<JudgeResponseDTO> GetJudges()
        {
            List<JudgeResponseDTO> judgeResponseDTOs = new List<JudgeResponseDTO>();
            List<Judges> judgs= _repo.Get().Where(jug=>jug.Active ==true).ToList();
           foreach(Judges jdg in judgs)
            {
                Country country = _countryRepository.GetByCountryName(jdg.CountryName);
                string countryFlg = "";
                if (country != null)
                {
                    countryFlg = country.FlagPath;
                }
                JudgeResponseDTO judgeResponseDTO = new JudgeResponseDTO();
                judgeResponseDTO.Id = jdg.Id;
                judgeResponseDTO.JudgeName = jdg.JudgeName;
                judgeResponseDTO.CountryName = jdg.CountryName;
                judgeResponseDTO.IsMember = jdg.IsMember;
                judgeResponseDTO.IsConflict = jdg.IsConflict;
                judgeResponseDTO.CountryFlag = countryFlg;
                judgeResponseDTO.GlobalId = jdg.GlobalId;
                judgeResponseDTO.DeletedBy = jdg.DeletedBy;
                judgeResponseDTOs.Add(judgeResponseDTO);
            }
           return judgeResponseDTOs;
        }
        public List<JudgeResponseDTO> GetSpinJudges()
        {
            List<JudgeResponseDTO> judgeResponseDTOs = new List<JudgeResponseDTO>();
            List<Judges> judgs = _repo.Get().Where(jug => jug.Active == true && jug.DeletedBy!=1).ToList();
            foreach (Judges jdg in judgs)
            {
                Country country = _countryRepository.GetByCountryName(jdg.CountryName);
                string countryFlg = "";
                if (country != null)
                {
                    countryFlg = country.FlagPath;
                }
                JudgeResponseDTO judgeResponseDTO = new JudgeResponseDTO();
                judgeResponseDTO.Id = jdg.Id;
                judgeResponseDTO.JudgeName = jdg.JudgeName;
                judgeResponseDTO.CountryName = jdg.CountryName;
                judgeResponseDTO.IsMember = jdg.IsMember;
                judgeResponseDTO.IsConflict = jdg.IsConflict;
                judgeResponseDTO.CountryFlag = countryFlg;
                judgeResponseDTO.GlobalId = jdg.GlobalId;
                judgeResponseDTO.DeletedBy = jdg.DeletedBy;
                judgeResponseDTOs.Add(judgeResponseDTO);
            }
            return judgeResponseDTOs;
        }
        private string StoreConsentDocumentation(IFormFile file, Judges judge)
        {
            if (file != null)
            {
                string url = $"{QR_STROAGE_PATH}{judge.GlobalId}";
                string savePath = InteractWithImage.Upload(file, url);
                return JsonConvert.SerializeObject(savePath).ToString();
            }

            return null;
        }
        public async Task<bool> UpdateProfileImage(Judges judge, string path)
        {
            Judges judges = CountryFlag(judge, path);
            Judges retJudge = await _repo.Update(judges);
            return true;
        }
        public static Judges CountryFlag(Judges judge, string path)
        {
            judge.CountryFlag = path;
            return judge;
        }
        public JudgeResponseDTO GetById(Guid id)
        {
            JudgeResponseDTO judgData = _repo.GetById(id);
            return judgData;
        }

        public Judges GetByIntId(Guid id)
        {
            return _repo.GetByGuId(id);
            
        }

        public async Task<JudgeResponseDTO> UpdateJudge(Guid id,JudgeRequestDTO request)
        {
            try
            {
                var judgeData = _repo.GetByGuId(id);

                judgeData.JudgeName = request.JudgeName;
                judgeData.CountryName = request.CountryName;
                judgeData.IsConflict = request.IsConflict;
                judgeData.IsMember = request.IsMember;
                judgeData.UpdatedAt = System.DateTime.Now;
                
                Judges newJudge = _repo.Update(judgeData).Result;

                if (newJudge != null)
                {
                    JudgeResponseDTO judgeResponseDTO = new JudgeResponseDTO()
                    {
                        Id = newJudge.Id,
                        JudgeName = newJudge.JudgeName,
                        CountryName = newJudge.CountryName,
                        IsMember = newJudge.IsMember,
                        IsConflict = newJudge.IsConflict,
                        CountryFlag = newJudge.CountryFlag,
                    };
                    return judgeResponseDTO;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new ApiException(ex.Message);
            }

        }
        public async Task<JudgeResponseDTO> DeleteJudge(Guid id)
        {
            try
            {
                var judgeData = _repo.GetByGuId(id);

                judgeData.Active = false;
                judgeData.DeletedAt = System.DateTime.Now;

                Judges newJudge = _repo.Update(judgeData).Result;

                if (newJudge != null)
                {
                    JudgeResponseDTO judgeResponseDTO = new JudgeResponseDTO()
                    {
                        Id = newJudge.Id,
                        JudgeName = newJudge.JudgeName,
                        CountryName = newJudge.CountryName,
                        IsMember = newJudge.IsMember,
                        IsConflict = newJudge.IsConflict,
                        CountryFlag = newJudge.CountryFlag,
                    };
                    return judgeResponseDTO;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new ApiException(ex.Message);
            }
        }
        public async Task<JudgeResponseDTO> DisableJudge(Guid id)
        {
            try
            {
                var judgeData = _repo.GetByGuId(id);

                judgeData.Active = true;
                judgeData.DeletedAt = System.DateTime.Now;
                judgeData.DeletedBy = 1;
                Judges newJudge = _repo.Update(judgeData).Result;

                if (newJudge != null)
                {
                    JudgeResponseDTO judgeResponseDTO = new JudgeResponseDTO()
                    {
                        Id = newJudge.Id,
                        JudgeName = newJudge.JudgeName,
                        CountryName = newJudge.CountryName,
                        IsMember = newJudge.IsMember,
                        IsConflict = newJudge.IsConflict,
                        CountryFlag = newJudge.CountryFlag,
                    };
                    return judgeResponseDTO;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new ApiException(ex.Message);
            }

        }

        public async Task<JudgeResponseDTO> EnableJudge(Guid id)
        {
            try
            {
                var judgeData = _repo.GetByGuId(id);

                judgeData.Active = true;
                judgeData.DeletedAt = System.DateTime.Now;
                judgeData.DeletedBy = 0;
                Judges newJudge = _repo.Update(judgeData).Result;

                if (newJudge != null)
                {
                    JudgeResponseDTO judgeResponseDTO = new JudgeResponseDTO()
                    {
                        Id = newJudge.Id,
                        JudgeName = newJudge.JudgeName,
                        CountryName = newJudge.CountryName,
                        IsMember = newJudge.IsMember,
                        IsConflict = newJudge.IsConflict,
                        CountryFlag = newJudge.CountryFlag,
                    };
                    return judgeResponseDTO;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new ApiException(ex.Message);
            }

        }
    }
}
