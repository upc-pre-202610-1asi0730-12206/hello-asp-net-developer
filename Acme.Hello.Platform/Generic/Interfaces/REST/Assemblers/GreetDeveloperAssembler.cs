using Acme.Hello.Platform.Generic.Domain.Model.Entities;
using Acme.Hello.Platform.Generic.Interfaces.REST.Resources;

namespace Acme.Hello.Platform.Generic.Interfaces.REST.Assemblers;

/// <summary>
/// Assembler class responsible for converting Developer entities into GreetDeveloperResponse objects.
/// </summary>
public static class GreetDeveloperAssembler
{
    /// <summary>
    /// Converts a Developer entity into a GreetDeveloperResponse. If the entity is null or has any empty name fields,
    /// it returns a response with a generic welcome message. Otherwise, it constructs a personalized greeting.
    /// </summary>
    /// <param name="entity">The Developer entity to convert into a GreetDeveloperResponse</param>
    /// <returns>A GreetDeveloperResponse containing the developer's ID, full name, and a personalized greeting message, or a generic welcome message if the entity is null or has empty name fields</returns>
    public static GreetDeveloperResponse ToResponseFromEntity(Developer? entity)
    {
        if (entity is null || entity.IsAnyNameEmpty())
            return new GreetDeveloperResponse("Welcome Anonymous ASP.NET Developer");
        return new GreetDeveloperResponse(entity.Id, entity.GetFullName(),
            $"Congrats {entity.GetFullName()}! You are an ASP.NET Developer");
    }
}