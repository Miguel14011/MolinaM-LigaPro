using Microsoft.AspNetCore.Mvc;
using MolinaM_LigaPro.Models;
using MolinaM_LigaPro.Repositories;

namespace MolinaM_LigaPro.Controllers
{
	public class EquipoController : Controller
	{
		public IActionResult ListaEqupos()
		{
			EquipoRepository repository = new EquipoRepository();
			var equipos = repository.DevuelveListadoEquipos();

			return View(equipos);
		}

		public IActionResult Edit(int Id)
		{
			EquipoRepository repository = new EquipoRepository();
			var equipo = repository.DevuelveInfoEquipo(Id);
			return View(equipo);
		
		}
	}
}
