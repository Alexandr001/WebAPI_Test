namespace AdminPanel.Models;

public class ProductModel
{
	public int Id { get; set; }
	
	public string Name { get; set; } = null!;
	public string? Description { get; set; }
	public decimal Price { get; set; }
	public byte[]? Image { get; set; }
	
	public int? CategoryId { get; set; }
	public CategoryModel? Category { get; set; }
}