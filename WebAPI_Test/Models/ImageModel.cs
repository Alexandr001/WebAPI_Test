using System.ComponentModel.DataAnnotations;

namespace WebAPI_Test.Models;

public class ImageModel
{
	public Guid Id { get; set; }
	[Required]
	public byte Image { get; set; }
	[Required]
	public string Expansion { get; set; } = null!;
}