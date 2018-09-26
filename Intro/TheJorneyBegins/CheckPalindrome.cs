public static class CheckPalindrome
{
    public static bool IsPalindrome(string inputString) 
    {
        var length = inputString.Length;

            for(var i = 0; i < length / 2; i++)
            {
                if (inputString[i] != inputString[length - i - 1])
                    return false;
            }
            return true;
    }
}