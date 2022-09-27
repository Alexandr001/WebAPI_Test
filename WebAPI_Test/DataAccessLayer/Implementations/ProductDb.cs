using Microsoft.EntityFrameworkCore;
using WebAPI_Test.BusinessLayer.Implementations;
using WebAPI_Test.DataAccessLayer.Interfaces;
using WebAPI_Test.Models;

namespace WebAPI_Test.DataAccessLayer.Implementations;

public class ProductDb : IProductDb
{
	public async Task<List<ProductModel>> GetAllProducts(Filtration? filtration)
	{
		await using (ApplicationContext context = new()) {
			return filtration switch {
					Filtration.NO_FILTER => await context.Product.ToListAsync(),
					Filtration.ORDER_BY_NAME => await context.Product.OrderBy(p => p.Name).ToListAsync(),
					Filtration.ORDER_BY_PRICE => await context.Product.OrderBy(p => p.Price).ToListAsync(),
					_ => await context.Product.ToListAsync()
			};
		}
	}
	public async Task<List<ProductModel>> GetProductByName(string name)
	{
		await using (ApplicationContext context = new()) {
			Task<List<ProductModel>> categories 
					= context.Product.Where(p =>
							                        EF.Functions.Like(p.Name!, $"%{name}%")).ToListAsync();
			return await categories;
		}
	}

	public async Task<ProductModel?> GetProductsById(int id)
	{
		await using (ApplicationContext context = new()) {
			return await context.Product.FindAsync(id);
		}
	}
}