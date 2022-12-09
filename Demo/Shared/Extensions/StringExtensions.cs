namespace Demo.Shared.Extensions;

public static class StringExtensions
{
    private const int maxLen = 15;
    /// <summary>
    /// Use this for prevent a line longer than 15 characters
    /// </summary>
    /// <param name="title">this string</param>
    /// <returns>Normalized string (e.g. "Some str...")</returns>
    public static string ToDefaultTitle(this string title)
    {
        var len = title.Length;

        if (len <= maxLen) return title;
        
        var endStr = "...";
        title = title.AsSpan(0, maxLen - endStr.Length).ToString() + endStr;

        return title;
    }
}