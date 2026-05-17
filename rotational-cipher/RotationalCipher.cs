public static class RotationalCipher
{
    public static string Rotate(string text, int shiftKey)
    {
        string result = "";
        for(int i = 0;i < text.Length;i++)
        {
            if(Char.IsDigit(text[i]) || text[i] == ' ') result += (char)text[i];
            else result += (char)(text[i] + shiftKey);
        }
            
        return result;
    }
}