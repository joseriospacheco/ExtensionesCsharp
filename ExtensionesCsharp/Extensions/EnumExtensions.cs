namespace ExtensionesCsharp.Extensions;
using System;


public static class EnumExtensions
{
    /// <summary>
    /// Convierte una enumeración en su valor entero.
    /// </summary>
    public static int ToInt<TEnum>(this TEnum enumValue) where TEnum : struct, Enum
    {
        return Convert.ToInt32(enumValue);
    }

    /// <summary>
    /// Convierte una enumeración en su representación de cadena (nombre del enum).
    /// </summary>
    public static string ToStringValue<TEnum>(this TEnum enumValue) where TEnum : struct, Enum
    {
        return enumValue.ToString();
    }

    /// <summary>
    /// Convierte un entero en su valor correspondiente de la enumeración.
    /// </summary>
    public static TEnum ToEnum<TEnum>(this int intValue) where TEnum : struct, Enum
    {
        if (Enum.IsDefined(typeof(TEnum), intValue))
        {
            return (TEnum)Enum.ToObject(typeof(TEnum), intValue);
        }
        throw new ArgumentException($"El valor {intValue} no es válido para el enum {typeof(TEnum).Name}.");
    }

    /// <summary>
    /// Convierte una cadena en su valor correspondiente de la enumeración.
    /// </summary>
    public static TEnum ToEnum<TEnum>(this string stringValue) where TEnum : struct, Enum
    {
        if (Enum.TryParse<TEnum>(stringValue, true, out var result))
        {
            return result;
        }
        throw new ArgumentException($"El valor '{stringValue}' no es válido para el enum {typeof(TEnum).Name}.");
    }
}
