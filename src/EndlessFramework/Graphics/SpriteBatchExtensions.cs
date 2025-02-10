namespace EndlessEscapade.Framework.Graphics;

/// <summary>
///     Provides <see cref="SpriteBatch" /> extension methods.
/// </summary>
/// <remarks>
///     Kept outside of the <c>Utilities</c> namespace for the sake of convenience.
/// </remarks>
public static class SpriteBatchExtensions
{
    /// <summary>
    ///     Captures the current state of the <see cref="SpriteBatch" /> as a <see cref="SpriteBatchParameters" /> instance.
    /// </summary>
    /// <param name="spriteBatch">The <see cref="SpriteBatch" /> to capture.</param>
    /// <returns>
    ///     A <see cref="SpriteBatchParameters" /> instance representing the current state of
    ///     <paramref name="spriteBatch" />.
    /// </returns>
    public static SpriteBatchParameters Capture(this SpriteBatch spriteBatch)
        => new
        (
            spriteBatch.sortMode,
            spriteBatch.blendState,
            spriteBatch.samplerState,
            spriteBatch.depthStencilState,
            spriteBatch.rasterizerState,
            spriteBatch.spriteEffect,
            spriteBatch.transformMatrix
        );

    /// <summary>
    ///     Begins the <see cref="SpriteBatch" /> using the specified <see cref="SpriteBatchParameters" />.
    /// </summary>
    /// <param name="spriteBatch">The <see cref="SpriteBatch" /> to begin.</param>
    /// <param name="parameters">The <see cref="SpriteBatchParameters" /> defining the state to apply.</param>
    public static void Begin(this SpriteBatch spriteBatch, in SpriteBatchParameters parameters)
        => spriteBatch.Begin
        (
            parameters.SpriteSortMode,
            parameters.BlendState,
            parameters.SamplerState,
            parameters.DepthStencilState,
            parameters.RasterizerState,
            parameters.Effect,
            parameters.TransformMatrix
        );
}