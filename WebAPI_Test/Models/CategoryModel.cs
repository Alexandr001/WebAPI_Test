﻿namespace WebAPI_Test.Models;

public class CategoryModel
{
	public Guid Id { get; set; }
	public string Name { get; set; } = null!;
	public ImageModel? Image { get; set; }
}