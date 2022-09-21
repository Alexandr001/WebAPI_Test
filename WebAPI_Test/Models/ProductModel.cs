namespace WebAPI_Test.Models;

public class ProductModel
{
	public Guid Id { get; set; }
	public string Title { get; set; } = null!;
	public string Description { get; set; } = null!;
	public decimal Price { get; set; }
	public byte Image { get; set; }
}