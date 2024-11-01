using ApplicationCore.Contracts.Repository;
using ApplicationCore.Entities;
using Infastructure.Data;
using Microsoft.AspNetCore.Mvc;

namespace MovieShop.WebMVC.ViewComponents
{
	public class GenresViewComponent : ViewComponent
	{
		private readonly IGenreRepositoryAsync _repo;
		public GenresViewComponent(IGenreRepositoryAsync repo)
		{
			_repo = repo;
		}
		public async Task<IViewComponentResult> InvokeAsync()
		{
			var items = await _repo.GetAllAsync();
			return View(items);
		}
	}
}
