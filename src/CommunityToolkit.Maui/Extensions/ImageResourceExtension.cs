namespace CommunityToolkit.Maui.Extensions;

/// <summary>
/// 
/// </summary>
public class ImageResourceExtension : IMarkupExtension<ImageSource>
{
	/// <summary>
	/// 
	/// </summary>
	public string Id { get; set; } = string.Empty;

	/// <summary>
	/// 
	/// </summary>
	/// <param name="serviceProvider"></param>
	/// <returns></returns>
	public ImageSource ProvideValue(IServiceProvider serviceProvider) => ImageSource.FromResource(Id, Application.Current?.GetType().Assembly);

	object? IMarkupExtension.ProvideValue(IServiceProvider serviceProvider) => ProvideValue(serviceProvider);
}
