public class Validator
{
    public static bool IsNullOrEmpty(string input)
    {
        return string.IsNullOrEmpty(input);
    }

    public static bool IsNotNullOrEmpty(string input)
    {
        return !string.IsNullOrEmpty(input);
    }
}