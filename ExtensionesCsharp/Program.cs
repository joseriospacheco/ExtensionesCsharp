using ExtensionesCsharp.Extensions;

namespace ExtensionesCsharp;

internal class Program
{
    static void Main(string[] args)
    {

   
        Console.WriteLine("Ingrese un número entero:");
        var valorInt = Console.ReadLine().ToInt();
        Console.WriteLine($"El número entero es: {valorInt}");
   
        Console.WriteLine("Ingrese un número double:");
        var valorDouble = Console.ReadLine().ToDouble();
        Console.WriteLine($"El número decimal es: {valorDouble}");


        Console.WriteLine("Ingrese un número decimal:");
        var valorDecimal = Console.ReadLine().ToDouble();
        Console.WriteLine($"El número decimal es: {valorDecimal}");

        Console.WriteLine("Ingrese una fecha (YYYY-MM-DD):");
        var valorFecha = Console.ReadLine().ToDateTime();
        Console.WriteLine($"La fecha es: {valorFecha}");

        Console.WriteLine("Ingrese una fecha (YYYY-MM-DD) para convertir a DateOnly:");
        var valorDateOnly = Console.ReadLine().ToDateOnly();
        Console.WriteLine($"La fecha en DateOnly es: {valorDateOnly}");

        Console.WriteLine("Ingrese un valor booleano (true/false):");
        var valorBool = Console.ReadLine().ToBool();
        Console.WriteLine($"El valor booleano es: {valorBool}");

   
        
        string textoConAcentos = "Maximiliano Peñalosa Ríos";
        Console.WriteLine("Texto original: " + textoConAcentos);
        Console.WriteLine("Texto sin acentos: " + textoConAcentos.RemoveAccents());
       

        Console.WriteLine(2.Square());

        string nombreCompleto = "Ana DE LAS SALAS";
        string capitalizado = nombreCompleto.CapitalizeName();
        Console.WriteLine(capitalizado);


        
        var fechaNacimiento = new DateTime(1992, 3, 2); // Cambia la fecha para probar
        int edad = fechaNacimiento.CalcularEdad();
        Console.WriteLine($"Edad: {edad} años"); // Salida: "Edad: XX años"


        var fechaNacimiento2 = new DateOnly(1992, 3, 2); // Cambia la fecha para probar
        edad = fechaNacimiento2.CalcularEdad();
        Console.WriteLine($"Edad: {edad} años"); // Salida: "Edad: XX años"
    }

}

