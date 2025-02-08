namespace EndlessFramework.Core;

/// <summary>
///     Provides a base class for defining components that can extend the behavior of <see cref="Projectile"/>.
/// </summary>
public abstract class ProjectileComponent : GlobalProjectile
{
    /// <summary>
    ///     Gets or sets whether this component is enabled.
    /// </summary>
    public bool Enabled { get; set; }
    
    /// <summary>
    ///     <inheritdoc cref="GlobalProjectile.InstancePerEntity"/>
    /// </summary>
    /// <remarks>
    ///     This property is overridden to return <see langword="true"/>.
    /// </remarks>  
    public sealed override bool InstancePerEntity { get; } = true;
}