public static class PasswordValidation
{
    public static bool ValidationPassword(string? password)
    {
        if (string.IsNullOrEmpty(password) || password.Length < 8)
            return false;

        bool hasDigit = password.Any(char.IsDigit);
        bool hasLatin = password.Any(c => (c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'));

        return hasDigit && hasLatin;
    }
}
