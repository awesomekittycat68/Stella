using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Text.Json;

namespace Stella
{
    public static class JsonWebToken
    {
        private static readonly JwtSecurityTokenHandler TokenHandler = new();
        private static readonly string secretKey = "i'm not that mean";

        /// <summary>
        /// Generates a JWT with the given claims and expiration.
        /// Arrays and objects are JSON-serialized; strings are kept as-is.
        /// </summary>
        public static string Generate(Dictionary<string, object?> claims, TimeSpan expiresIn)
        {
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var jwtClaims = new List<Claim>();
            foreach (var pair in claims)
            {
                if (pair.Value == null) continue;

                string value;

                if (pair.Value is string s)
                {
                    value = s;
                }
                else if (pair.Value is System.Collections.IEnumerable && pair.Value is not string)
                {
                    value = JsonSerializer.Serialize(pair.Value);
                }
                else
                {
                    value = JsonSerializer.Serialize(pair.Value);
                }

                jwtClaims.Add(new Claim(pair.Key, value));
            }

            var token = new JwtSecurityToken(
                claims: jwtClaims,
                expires: DateTime.UtcNow.Add(expiresIn),
                signingCredentials: creds
            );

            return TokenHandler.WriteToken(token);
        }

        /// <summary>
        /// Verifies a JWT. Returns true if valid, false otherwise.
        /// </summary>
        public static bool Verify(string? token)
        {
            if (string.IsNullOrWhiteSpace(token)) return false;

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey));
            var parameters = new TokenValidationParameters
            {
                ValidateIssuer = false,
                ValidateAudience = false,
                ValidateLifetime = true,
                IssuerSigningKey = key,
                ClockSkew = TimeSpan.FromMinutes(5) // give some leeway
            };

            try
            {
                TokenHandler.ValidateToken(token, parameters, out _);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Decodes a JWT without verifying signature.
        /// </summary>
        public static IDictionary<string, object>? Decode(string? token)
        {
            if (string.IsNullOrWhiteSpace(token)) return null;

            try
            {
                var jwt = TokenHandler.ReadJwtToken(token);
                var payload = new Dictionary<string, object>();

                foreach (var kv in jwt.Payload)
                    payload[kv.Key] = kv.Value;

                return payload;
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Verifies and decodes a JWT. Returns null if invalid.
        /// </summary>
        public static IDictionary<string, object>? VerifyAndDecode(string? token)
        {
            if (string.IsNullOrWhiteSpace(token)) return null;

            if (token.StartsWith("Bearer ", StringComparison.OrdinalIgnoreCase))
                token = token["Bearer ".Length..];

            if (!Verify(token)) return null;

            return Decode(token);
        }
    }
}
