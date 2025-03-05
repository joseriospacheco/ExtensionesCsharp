using ExtensionesCsharp.Dtos;
using ExtensionesCsharp.Entities;

namespace ExtensionesCsharp.Extensions;
public static class PersonaExtensions
{
    public static PersonaDto  ToDto(this Persona persona)
    {
        return new PersonaDto
        {
            Nombre = persona.Nombre,
            Apellido = persona.Apellido,
            Edad = persona.Edad
        };
    }
    public static Persona ToEntity(this PersonaDto personaDto)
    {
        return new Persona
        {
            Nombre = personaDto.Nombre,
            Apellido = personaDto.Apellido,
            Edad = personaDto.Edad
        };
    }
}

