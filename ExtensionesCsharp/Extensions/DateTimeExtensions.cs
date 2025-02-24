
namespace ExtensionesCsharp.Extensions;
public static class DateTimeExtensions
{
    public static int CalcularEdad(this DateTime fechaNacimiento)
    {
        var fechaActual = DateTime.Today;
        var edad = fechaActual.Year - fechaNacimiento.Year;

        // Verifica si aún no ha cumplido años este año
        if (fechaNacimiento.Date > fechaActual.AddYears(-edad))
        {
            edad--;
        }

        return edad;
    }

    public static int CalcularEdad(this DateOnly fechaNacimiento)
    {
        var fechaActual = DateOnly.FromDateTime(DateTime.Today);
        var edad = fechaActual.Year - fechaNacimiento.Year;

        // Verifica si aún no ha cumplido años este año
        if (fechaNacimiento > fechaActual.AddYears(-edad))
        {
            edad--;
        }

        return edad;
    }

}