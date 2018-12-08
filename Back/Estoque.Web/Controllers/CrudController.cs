using Estoque.DAL.Entities;
using Estoque.DAL.InterfacesRepository;
using Estoque.DAL.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Estoque.Web.Controllers
{
    public class CrudController<T, E> : Controller
        where T : Repository<E>
        where E : Entity
    {
        protected IRepository<E> _repository;
        protected IUnitOfWork _uow;

        public CrudController(IUnitOfWork unitOfWork)
        {
            _uow = unitOfWork;
        }

        public async Task<IActionResult> Index()
        {
            var a = await _repository.ToListAsync();
            return View(a);
        }

        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var entity = await _repository.FirstOrDefaultAsync(m => m.Id == id);
            if (entity == null)
            {
                return NotFound();
            }

            return View(entity);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(E entity)
        {
            if (ModelState.IsValid)
            {
                _repository.Add(entity);
                await _uow.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(entity);
        }

        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var entity = await _repository.FindAsync(id);
            if (entity == null)
            {
                return NotFound();
            }
            return View(entity);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(E entity)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _repository.Update(entity);
                    await _uow.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EntityExists(entity.Id))
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
            return View(entity);
        }

        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var entity = await _repository.FirstOrDefaultAsync(m => m.Id == id);
            if (entity == null)
            {
                return NotFound();
            }

            return View(entity);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var entity = await _repository.FindAsync(id);
            _repository.Remove(entity);
            await _uow.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EntityExists(long id)
        {
            return _repository.Any(e => e.Id == id);
        }
    }
}