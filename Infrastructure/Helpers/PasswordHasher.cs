﻿

namespace Infrastructure.Helpers;

public class PasswordHasher
{
    public static (string, string) GenerateSecurePassword(string password)
    {
        using var hmac = new HMACSHA512();
        var securityKey = hmac.Key;
        var hashedPassword = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));

        return (Convert.ToBase64String(securityKey), Convert.ToBase64String(hashedPassword));
    }



    public static bool ValidateSecurePassword(string password, string hash, string securityKey)
    {
        var security = Convert.FromBase64String(securityKey);
        var pwd = Convert.FromBase64String(hash);

        using var hmac = new HMACSHA512(security);
        var hashedPassword = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));

        for (var i = 0; i < hashedPassword.Length; i++)
        {
            if (hashedPassword[i] != hash[i])
                return false;
        }

        return true;
    }




}
