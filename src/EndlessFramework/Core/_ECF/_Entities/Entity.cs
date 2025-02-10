using System.Diagnostics.CodeAnalysis;

namespace EndlessEscapade.Framework.Core;

public readonly struct Entity : IEquatable<Entity>
{
    /// <summary>
    ///     Gets the unique identity of the entity.
    /// </summary>
    public int Identity { get; }

    internal Entity(int identity)
    {
        ArgumentOutOfRangeException.ThrowIfNegative(identity, nameof(identity));

        Identity = identity;
    }

    /// <summary>
    ///     Gets the component of the specified type from the entity.
    /// </summary>
    /// <typeparam name="T">The type of the component to get.</typeparam>
    /// <returns>The instance of the retrieved component of the specified type.</returns>
    public ref T Get<T>() where T : IComponent
        => throw new NotImplementedException();

    /// <summary>
    ///     Sets the component of the specified type to the entity.
    /// </summary>
    /// <typeparam name="T">The type of the component to set.</typeparam>
    public void Set<T>() where T : IComponent
        => throw new NotImplementedException();

    /// <summary>
    ///     Checks whether the entity has a component of the specified type.
    /// </summary>
    /// <typeparam name="T">The type of the component to check.</typeparam>
    /// <returns><c>true</c> if the entity has a component of the specified type; otherwise, <c>false</c>.</returns>
    public bool Has<T>() where T : IComponent
        => throw new NotImplementedException();

    /// <summary>
    ///     Removes the component of the specified type from the entity.
    /// </summary>
    /// <typeparam name="T">The type of the component to remove.</typeparam>
    /// <returns><c>true</c> if the component was successfully removed from the entity; otherwise, <c>false</c>.</returns>
    public bool Remove<T>() where T : IComponent
        => throw new NotImplementedException();

    public bool Equals(Entity other)
        => Identity == other.Identity;

    public override bool Equals([NotNullWhen(true)] object? obj)
        => obj is Entity other && Equals(other);

    public override string ToString()
        => $"Identity: {Identity}";

    public override int GetHashCode()
        => Identity;

    public static bool operator ==(Entity left, Entity right)
        => left.Identity == right.Identity;

    public static bool operator !=(Entity left, Entity right)
        => left.Identity != right.Identity;
}