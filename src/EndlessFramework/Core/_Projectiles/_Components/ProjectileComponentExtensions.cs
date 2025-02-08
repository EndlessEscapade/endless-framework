using System.Diagnostics.CodeAnalysis;

namespace EndlessFramework.Core;

/// <summary>
///     Provides <see cref="Projectile"/> extension methods regarding <see cref="ProjectileComponent"/>.
/// </summary>
/// <remarks>
///     Kept outside of the <c>Utilities</c> namespace for the sake of convenience.
/// </remarks>
public static class ProjectileComponentExtensions
{
    public static bool TryEnable<T>(this Projectile projectile, [NotNullWhen(true)] out T? component) where T : ProjectileComponent
    {
        if (!projectile.TryGetGlobalProjectile(out component))
        {
            return false;
        }
        
        component!.Enabled = true;

        return true;
    }
}