namespace AdminPanelApi.Models;

public class CategoryModel
{
	public int Id { get; set; }
	public string Name { get; set; } = null!;
	public IFormFile? Image { get; set; }

	public List<ProductModel>? Products { get; set; }
}