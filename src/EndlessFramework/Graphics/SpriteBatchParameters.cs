namespace EndlessFramework.Graphics;

public struct SpriteBatchParameters
(
    SpriteSortMode spriteSortMode,
    BlendState blendState,
    SamplerState samplerState,
    DepthStencilState depthStencilState,
    RasterizerState rasterizerState,
    Effect effect,
    Matrix transformMatrix
)
{
    /// <summary>
    ///     Gets or sets the sprite sort mode.
    /// </summary>
    public SpriteSortMode SpriteSortMode { readonly get; set; } = spriteSortMode;

    /// <summary>
    ///     Gets or sets the blend state.
    /// </summary>
    public BlendState BlendState { readonly get; set; } = blendState;

    /// <summary>
    ///     Gets or sets the sampler state.
    /// </summary>
    public SamplerState SamplerState { readonly get; set; } = samplerState;

    /// <summary>
    ///     Gets or sets the depth stencil state.
    /// </summary>
    public DepthStencilState DepthStencilState { readonly get; set; } = depthStencilState;

    /// <summary>
    ///     Gets or sets the rasterizer state.
    /// </summary>
    public RasterizerState RasterizerState { readonly get; set; } = rasterizerState;

    /// <summary>
    ///     Gets or sets the effect.
    /// </summary>
    public Effect Effect { readonly get; set; } = effect;

    /// <summary>
    ///     Gets or sets the transform matrix.
    /// </summary>
    public Matrix TransformMatrix { readonly get; set; } = transformMatrix;
}