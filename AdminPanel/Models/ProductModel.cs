namespace AdminPanel.Models;

public class ProductModel
{
	public Guid Id { get; set; }
	public string Name { get; set; } = null!;
	public string? Description { get; set; }
	public decimal Price { get; set; }
	public CategoryModel? Category { get; set; }
	public ImageModel? Image { get; set; }
}