#nullable disable
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using sitevascoutinho.Models.Classes;

namespace sitevascoutinho.Controllers
{
	public class NoticiasController : Controller
	{
		private readonly DBContext _context;

		public NoticiasController(DBContext context)
		{
			_context = context;
		}

		// GET: Noticias
		public async Task<IActionResult> Index()
		{
			return View(await _context.GuardarNoticia.ToListAsync());
		}

		// GET: Noticias/Details/5
		public async Task<IActionResult> Details(int? id)
		{
			if (id == null)
			{
				return NotFound();
			}

			var noticia = await _context.GuardarNoticia
				.FirstOrDefaultAsync(m => m.Id == id);
			if (noticia == null)
			{
				return NotFound();
			}

			return View(noticia);
		}

		// GET: Noticias/Create
		public IActionResult Create()
		{
			return View();
		}

		// POST: Noticias/Create
		// To protect from overposting attacks, enable the specific properties you want to bind to.
		// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Create([Bind("Id,Titulo,Corpo,Descricao")] Noticia noticia)
		{
			if (ModelState.IsValid)
			{
				_context.Add(noticia);
				await _context.SaveChangesAsync();
				return RedirectToAction(nameof(Index));
			}
			return View(noticia);
		}

		// GET: Noticias/Edit/5
		public async Task<IActionResult> Edit(int? id)
		{
			if (id == null)
			{
				return NotFound();
			}

			var noticia = await _context.GuardarNoticia.FindAsync(id);
			if (noticia == null)
			{
				return NotFound();
			}
			return View(noticia);
		}

		// POST: Noticias/Edit/5
		// To protect from overposting attacks, enable the specific properties you want to bind to.
		// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Edit(int id, [Bind("Id,Titulo,Corpo,Descricao")] Noticia noticia)
		{
			if (id != noticia.Id)
			{
				return NotFound();
			}

			if (ModelState.IsValid)
			{
				try
				{
					_context.Update(noticia);
					await _context.SaveChangesAsync();
				}
				catch (DbUpdateConcurrencyException)
				{
					if (!NoticiaExists(noticia.Id))
					{
						return NotFound();
					}
					else
					{
						throw;
					}
				}
				return RedirectToAction(nameof(Index));
			}
			return View(noticia);
		}

		// GET: Noticias/Delete/5
		public async Task<IActionResult> Delete(int? id)
		{
			if (id == null)
			{
				return NotFound();
			}

			var noticia = await _context.GuardarNoticia
				.FirstOrDefaultAsync(m => m.Id == id);
			if (noticia == null)
			{
				return NotFound();
			}

			return View(noticia);
		}

		// POST: Noticias/Delete/5
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> DeleteConfirmed(int id)
		{
			var noticia = await _context.GuardarNoticia.FindAsync(id);
			_context.GuardarNoticia.Remove(noticia);
			await _context.SaveChangesAsync();
			return RedirectToAction(nameof(Index));
		}

		private bool NoticiaExists(int id)
		{
			return _context.GuardarNoticia.Any(e => e.Id == id);
		}
	}
}
