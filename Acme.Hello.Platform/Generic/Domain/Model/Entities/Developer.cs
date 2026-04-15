namespace Acme.Hello.Platform.Generic.Domain.Model.Entities;

/// <summary>
/// Represents a developer with a unique identifier, first name, and last name.
/// </summary>
/// <param name="firstName">The first name of the developer. If null or whitespace, it will be set to an empty string.</param>
/// <param name="lastName">The last name of the developer. If null or whitespace, it will be set to an empty string.</param>
public class Developer(string firstName, string lastName)
{
    public Guid Id { get; } = Guid.NewGuid();
    public string FirstName { get; } = string.IsNullOrWhiteSpace(firstName) ? "" : firstName.Trim();
    public string LastName { get; } = string.IsNullOrWhiteSpace(lastName) ? "" : lastName.Trim();
    
    /// <summary>
    /// Returns the full name of the developer by concatenating the first name and last name.
    /// </summary>
    /// <returns>A string representing the full name of the <see cref="Developer"/> object.</returns>
    public string GetFullName() => $"{FirstName} {LastName}".Trim();
    
    /// <summary>
    /// Checks if either the first name or last name of the developer is empty.
    /// </summary>
    /// <returns>True if either the first name or last name is empty; otherwise, false.</returns>
    public bool IsAnyNameEmpty() => string.IsNullOrEmpty(FirstName) 
                                    || string.IsNullOrEmpty(LastName);
}