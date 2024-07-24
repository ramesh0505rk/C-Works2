public static class StringExtensions
{
    public static int WordCount(this string str)
    {
        if (string.IsNullOrWhiteSpace(str))
            return 0;
        string[] word = str.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
        return word.Length;
    }
}
class MyExtensions
{
    public void MainMethod()
    {
        string s = "Hey all, how are you?";
        System.Console.WriteLine(s.WordCount());
    }
}
