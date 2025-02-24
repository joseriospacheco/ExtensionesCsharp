using System.Globalization;
using System.Text;

namespace ExtensionesCsharp.Extensions;
public static class StringExtensions
{


    public static int ToInt(this string value)
    {
        return Convert.ToInt32(value);
    }

    public static double ToDouble(this string value)
    {
        return Convert.ToDouble(value);
    }

    public static decimal ToDecimal(this string value)
    {
        return Convert.ToDecimal(value);
    }


    public static DateTime ToDateTime(this string value)
    {
        return DateTime.Parse(value);
    }

    public static DateOnly ToDateOnly(this string value)
    {
        return DateOnly.Parse(value);
    }

    public static bool ToBool(this string value)
    {
        return bool.Parse(value);
    }

    public static string RemoveAccents(this string texto)
    {
        var acentos = new Dictionary<char, char>
        {
            { 'á', 'a' }, { 'é', 'e' }, { 'í', 'i' }, { 'ó', 'o' }, { 'ú', 'u' },{ 'Á', 'A' }, { 'É', 'E' }, { 'Í', 'I' }, { 'Ó', 'O' }, { 'Ú', 'U' }
        };

        var sb = new StringBuilder();
        foreach (char c in texto)
        {

            if (acentos.ContainsKey(c))
            {
                sb.Append(acentos[c]);
            }
            else
            {
                sb.Append(c);
            }
        }
        return sb.ToString();
    }

    private static readonly string[] Particulas =
    {
        "de", "del", "la", "las", "los"
    };

    public static string CapitalizeName(this string text)
    {
        if (string.IsNullOrWhiteSpace(text))
            return string.Empty;

        TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;

        // Separar el texto en palabras
        string[] words = text.ToLower().Split(' ');

        for (int i = 0; i < words.Length; i++)
        {
            // Siempre se capitaliza la primera palabra
            if (i == 0 || !Particulas.Contains(words[i]))
            {
                words[i] = textInfo.ToTitleCase(words[i]);
            }
        }

        return string.Join(" ", words);
    }


    public static int WordCount(this string str)
    {
        if (string.IsNullOrWhiteSpace(str)) return 0;
        return str.Split(' ').Length;
    }

}
