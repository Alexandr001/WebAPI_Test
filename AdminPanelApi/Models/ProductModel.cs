namespace AdminPanelApi.Models;

public class ProductModel
{
	public int Id { get; set; }
	public string Name { get; set; } = null!;
	public string? Description { get; set; }
	public decimal Price { get; set; }
	public IFormFile? Image { get; set; }
	
	public int? CategoryId { get; set; }
}