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
        private readonly string QR_STROAGE_PATH = "/user/";
        public JudgesServices(IJudgesRepository repo)
        {
            _repo = repo;
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
                newJudge.CountryFlag = StoreConsentDocumentation(request.CountryFlag, newJudge);
                await UpdateProfileImage(newJudge, newJudge.CountryFlag);
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
            List<Judges> judgs= _repo.Get().ToList();
           foreach(Judges jdg in judgs)
            {
                JudgeResponseDTO judgeResponseDTO = new JudgeResponseDTO();
                judgeResponseDTO.Id = jdg.Id;
                judgeResponseDTO.JudgeName = jdg.JudgeName;
                judgeResponseDTO.CountryName = jdg.CountryName;
                judgeResponseDTO.IsMember = jdg.IsMember;
                judgeResponseDTO.IsConflict = jdg.IsConflict;
                judgeResponseDTO.CountryFlag = jdg.CountryFlag;
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
    }
}
