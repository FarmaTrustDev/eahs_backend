using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.IdentityModel.Tokens;
using System.Collections.Generic;
using System.Linq.Expressions;
using System;
using EAHS.Infrastructure;
using EAHS.Repositories;
using EAHS.DTOS;
using EAHS.Models;
using System.Linq;
using EAHS.Helper;
using EAHS.Helper.ExceptionHendling;

namespace EAHS.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly AppConfiguration _appConfiguration;
        private readonly EAHSDbContext _CGTContext;
        private readonly IUserConnectionManager _userConnectionManager;
        public AuthController(AppConfiguration appConfiguration, EAHSDbContext CGTContext,
                              IUserConnectionManager userConnectionManager)
        {
            _appConfiguration = appConfiguration;
            _CGTContext = CGTContext;
            _userConnectionManager = userConnectionManager;
        }
        [HttpPost]
        public AuthResponse Post([FromBody] AuthRequest request)
        {
            return AuthenticateUser(request);
        }
        private AuthResponse AuthenticateUser(AuthRequest request)
        {
            Expression<Func<User, bool>> expression = x => ((x.Email.ToLower() == Convert.ToString(request.Username).ToLower()) || x.UserName.ToLower() == Convert.ToString(request.Username).ToLower() && x.Active == true);

            User existingUser = _CGTContext.User.SingleOrDefault(expression);

            AuthResponse response = new AuthResponse();

            if (existingUser != null)
            {
                if (existingUser.Password == Helper.Utility.Encrypt(request.Password))
                {
                    IDictionary<string, object> payloadAccessToken = new Dictionary<string, object>
                    {
                        { AccessTokenKeys.Id, existingUser.Id.ToString() },
                         { AccessTokenKeys.Username, existingUser.UserName },
                        { AccessTokenKeys.Email, existingUser.Email }
                    };

                    IDictionary<string, object> payloadRefreshToken = new Dictionary<string, object>
                    {
                        { AccessTokenKeys.Id, existingUser.Id },
                         { AccessTokenKeys.Username, request.Username },
                        { AccessTokenKeys.Email, request.Email },
                        { AccessTokenKeys.Password, Encryption.Encrypt(request.Password) }
                    };

                    response.Success = true;
                    response.AccessToken = JwtManager.GenerateAccessToken(_appConfiguration.JwtSecretKey, payloadAccessToken);
                    response.RefreshToken = JwtManager.GenerateRefreshToken(_appConfiguration.JwtSecretKey, payloadRefreshToken);
                    response.Message = "Login Success!";
                }
                else
                {
                    throw new ApiException("Unauthorized user.", 401);
                }
            }
            else
            {
                throw new ApiException("Unauthorized user.", 401);
            }

            return response;
        }


        /*[HttpGet]
        [Route("private-key-activation/{privateKey}")]
        public AuthResponse Get(string privateKey)
        {
            return AuthenticateUser(privateKey);
        }
        private AuthResponse AuthenticateUser(string request)
        {
            Expression<Func<ResetPassword, bool>> expression = x => (x.PrivateKey == Convert.ToString(request));

            ResetPassword existingUserKey = _CGTContext.ResetPassword.FirstOrDefault(expression);
            User existingUser = null;
            if (existingUserKey != null)
            {
                Expression<Func<User, bool>> expressionUser = x => (x.GlobalId == existingUserKey.UserId);
                existingUser = _CGTContext.User.FirstOrDefault(expressionUser);
            }
            AuthResponse response = new AuthResponse();

            if (existingUser != null)
            {
                if (existingUserKey.PrivateKey == request)
                {
                    IDictionary<string, object> payloadAccessToken = new Dictionary<string, object>
                    {
                        { AccessTokenKeys.Id, existingUser.Id.ToString() },
                         { AccessTokenKeys.OrgnizationId, existingUser.OrganizationId.ToString() },
                          { AccessTokenKeys.OrgnizationIdTypeId, existingUser.OrganizationTypeId.ToString() },
                        { AccessTokenKeys.Username, existingUser.UserName },
                        { AccessTokenKeys.Email, existingUser.Email }
                    };

                    IDictionary<string, object> payloadRefreshToken = new Dictionary<string, object>
                    {
                        { AccessTokenKeys.Id, existingUser.Id },
                         { AccessTokenKeys.OrgnizationId, existingUser.OrganizationId.ToString() },
                          { AccessTokenKeys.OrgnizationIdTypeId, existingUser.OrganizationTypeId.ToString() },
                        { AccessTokenKeys.Username, existingUser.UserName },
                        { AccessTokenKeys.Email, existingUser.Email },
                        { AccessTokenKeys.Password, request }
                    };

                    response.Success = true;
                    response.AccessToken = JwtManager.GenerateAccessToken(_appConfiguration.JwtSecretKey, payloadAccessToken);
                    response.RefreshToken = JwtManager.GenerateRefreshToken(_appConfiguration.JwtSecretKey, payloadRefreshToken);
                    response.Message = "";
                }
                else
                {
                    throw new ApiException("Unauthorized user.", 401);
                }
            }
            else
            {
                throw new ApiException("Unauthorized user.", 401);
            }

            return response;
        }*/

        /*[HttpPost]
        [Route("get-key-with-email")]
        public AuthResponse GetEmailKey([FromBody] AuthRequest request)
        {
            return AuthenticateUserByEmail(request.Email);
        }
        private AuthResponse AuthenticateUserByEmail(string request)
        {
            Expression<Func<User, bool>> expression = x => (x.Email == Convert.ToString(request) && x.Active == true);

            User existingUserKey = _CGTContext.User.FirstOrDefault(expression);

            Expression<Func<User, bool>> expressionUser = x => (x.GlobalId == existingUserKey.GlobalId);

            User existingUser = _CGTContext.User.FirstOrDefault(expressionUser);

            AuthResponse response = new AuthResponse();

            if (existingUser != null)
            {
                if (existingUserKey.Email == request)
                {
                    IDictionary<string, object> payloadAccessToken = new Dictionary<string, object>
                    {
                        { AccessTokenKeys.Id, existingUser.Id.ToString() },
                         { AccessTokenKeys.OrgnizationId, existingUser.OrganizationId.ToString() },
                          { AccessTokenKeys.OrgnizationIdTypeId, existingUser.OrganizationTypeId.ToString() },
                        { AccessTokenKeys.Username, existingUser.UserName },
                        { AccessTokenKeys.Email, existingUser.Email }
                    };

                    IDictionary<string, object> payloadRefreshToken = new Dictionary<string, object>
                    {
                        { AccessTokenKeys.Id, existingUser.Id },
                         { AccessTokenKeys.OrgnizationId, existingUser.OrganizationId.ToString() },
                          { AccessTokenKeys.OrgnizationIdTypeId, existingUser.OrganizationTypeId.ToString() },
                        { AccessTokenKeys.Username, existingUser.UserName },
                        { AccessTokenKeys.Email, existingUser.Email },
                        { AccessTokenKeys.Password, request }
                    };

                    response.Success = true;
                    response.AccessToken = JwtManager.GenerateAccessToken(_appConfiguration.JwtSecretKey, payloadAccessToken);
                    response.RefreshToken = JwtManager.GenerateRefreshToken(_appConfiguration.JwtSecretKey, payloadRefreshToken);
                    response.Message = "";
                }
                else
                {
                    throw new ApiException("Unauthorized user.", 401);
                }
            }
            else
            {
                throw new ApiException("Unauthorized user.", 401);
            }

            return response;
        }*/


        /*[HttpPost]
        [Route("refresh")]
        public AuthResponse PostRefresh([FromBody] AuthRefreshRequest request)
        {
            bool isValid = JwtManager.IsValidToken(request.RefreshToken, _appConfiguration.JwtSecretKey, true);
            _ = new AuthResponse();
            AuthResponse response;
            if (isValid)
            {
                string username = string.Empty;
                string password = string.Empty;
                string email = string.Empty;

                if (JwtManager.KeyExistsInPayload(AccessTokenKeys.Username, request.RefreshToken, _appConfiguration.JwtSecretKey))
                {
                    username = JwtManager.GetItem<string>(AccessTokenKeys.Username, request.RefreshToken, _appConfiguration.JwtSecretKey);
                }

                if (JwtManager.KeyExistsInPayload(AccessTokenKeys.Email, request.RefreshToken, _appConfiguration.JwtSecretKey))
                {
                    email = JwtManager.GetItem<string>(AccessTokenKeys.Email, request.RefreshToken, _appConfiguration.JwtSecretKey);
                }

                if (JwtManager.KeyExistsInPayload(AccessTokenKeys.Password, request.RefreshToken, _appConfiguration.JwtSecretKey))
                {
                    password = Encryption.Decrypt(JwtManager.GetItem<string>(AccessTokenKeys.Password, request.RefreshToken, _appConfiguration.JwtSecretKey));
                }

                AuthRequest authRequest = new AuthRequest { Username = username, Password = password, Email = email };
                response = AuthenticateUser(authRequest);
            }
            else
            {
                throw new ApiException("Unauthorized user.", 401);
            }

            return response;
        }*/
    }
}