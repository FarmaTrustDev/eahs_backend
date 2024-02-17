﻿using Microsoft.IdentityModel.Tokens;
using System.Collections.Generic;
using JWT;
using JWT.Algorithms;
using JWT.Serializers;
using System;
using EAHS.Helper.ExceptionHendling;

namespace EAHS.Helper
{
    public class JwtManager
    {
        private const string HMAC_ALGORITHM = "HmacSHA256";
        public const int ACCESS_TOKEN_EXPIRATION_IN_MINUTES = 720;
        public const int REFRESH_TOKEN_EXPIRATION_IN_MINUTES = 720; //  One day

        private static string GenerateToken(string secretKey, int tokenExpirationInMinutes, IDictionary<string, object> payload)
        {
            DateTime unixEpoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            double expiry = Math.Round((DateTime.UtcNow.AddMinutes(tokenExpirationInMinutes) - unixEpoch).TotalSeconds);
            double issuedAt = Math.Round((DateTime.UtcNow - unixEpoch).TotalSeconds);
            string username = string.Empty;

            //if (payload["username"] != null && payload["username"] != "")
            //{
            //    username = payload["username"].ToString();
            //}

            payload["sub"] = username;
            payload["iat"] = issuedAt;
            payload["exp"] = expiry;

            return SerializeToken(secretKey, payload);
        }

        private static IJwtEncoder GetJwtEncoder()
        {
            IJwtAlgorithm algorithm = new HMACSHA256Algorithm();
            IJsonSerializer serializer = new JsonNetSerializer();
            IBase64UrlEncoder urlEncoder = new JwtBase64UrlEncoder();
            IJwtEncoder encoder = new JwtEncoder(algorithm, serializer, urlEncoder);

            return encoder;
        }

        private static IJwtDecoder GetJwtDecoder()
        {
            IJwtAlgorithm algorithm = new HMACSHA256Algorithm();
            IJsonSerializer serializer = new JsonNetSerializer();
            IDateTimeProvider provider = new UtcDateTimeProvider();
            IJwtValidator validator = new JwtValidator(serializer, provider);
            IBase64UrlEncoder urlEncoder = new JwtBase64UrlEncoder();
            IJwtDecoder decoder = new JwtDecoder(serializer, validator, urlEncoder, algorithm);

            return decoder;
        }

        public static string SerializeToken(string secretKey, IDictionary<string, object> payload)
        {
            IJwtEncoder encoder = GetJwtEncoder();

            return encoder.Encode(payload, secretKey);
        }

        public static Dictionary<string, object> DeserializeToken(string token, string secretKey)
        {
            if (token == null || token == "")
            {
                throw new ApiException("Unauthorized user.", 401);
            }
            IJwtDecoder decoder = GetJwtDecoder();
            string payloadJson = decoder.Decode(token, secretKey, verify: true);

            return Serializer.Deserialize<Dictionary<string, object>>(payloadJson);
        }

        public static string GenerateAccessToken(string secretKey, IDictionary<string, object> payload)
        {
            return GenerateToken(secretKey, ACCESS_TOKEN_EXPIRATION_IN_MINUTES, payload);
        }

        public static string GenerateRefreshToken(string secretKey, IDictionary<string, object> payload)
        {
            return GenerateToken(secretKey, REFRESH_TOKEN_EXPIRATION_IN_MINUTES, payload);
        }

        public static bool IsValidToken(string token, string secretKey, bool checkExpiration = true)
        {
            bool result = false;
            Dictionary<string, object> payload = null;

            try
            {
                payload = DeserializeToken(token, secretKey);
            }
            catch
            {
                payload = null;
            }

            object expiryTime;

            if (payload != null)
            {
                if (checkExpiration)
                {
                    if (payload.TryGetValue("exp", out expiryTime))
                    {
                        DateTime unixEpoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
                        DateTime validTo = unixEpoch.AddSeconds(long.Parse(expiryTime.ToString()));

                        if (DateTime.Compare(validTo, DateTime.UtcNow) <= 0)
                        {
                            result = false;
                        }
                        else
                        {
                            result = true;
                        }
                    }
                }
            }

            return result;
        }

        public static string DecodeJwtToken(string token)
        {
            IJwtDecoder jwtDecoder = GetJwtDecoder();

            return jwtDecoder.Decode(token);
        }

        public static object GetItem(string dictionaryKey, string token, string secretKey)
        {
            object item = null;
            IDictionary<string, object> payload = DeserializeToken(token, secretKey);

            if (payload != null)
            {
                payload.TryGetValue(dictionaryKey, out item);
            }

            return item;
        }

        public static T GetItem<T>(string dictionaryKey, string token, string secretKey)
        {
            object item = null;
            IDictionary<string, object> payload = DeserializeToken(token, secretKey);

            if (payload != null)
            {
                payload.TryGetValue(dictionaryKey, out item);
            }

            return (T)Convert.ChangeType(item, typeof(T));
        }

        public static bool KeyExistsInPayload(string dictionaryKey, string token, string secretKey)
        {
            bool exists = false;
            IDictionary<string, object> payload = DeserializeToken(token, secretKey);

            if (payload != null)
            {
                exists = payload.ContainsKey(dictionaryKey);
            }

            return exists;
        }
    }
}
