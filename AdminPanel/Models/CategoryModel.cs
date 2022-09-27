using Microsoft.Build.Framework;

namespace AdminPanel.Models;

public class CategoryModel
{
	public int Id { get; set; }
	public string Name { get; set; } = null!;
	public byte[]? Image { get; set; }
	public ICollection<ProductModel>? Products { get; set; }
}