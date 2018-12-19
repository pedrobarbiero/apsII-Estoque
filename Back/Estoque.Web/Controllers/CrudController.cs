using Estoque.Entities;
using Estoque.DAL.InterfacesRepository;
using Estoque.DAL.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace Estoque.Web.Controllers
{
    public class CrudController<T, E> : Controller 
        where T : Repository<E>
        where E : Entity
    {
        protected IRepository<E> _repository;
        protected IUnitOfWork _uow; 

        protected virtual void LoadDropdown(E entity)
        {

        }

        public CrudController(IUnitOfWork unitOfWork)
        {
            _uow = unitOfWork;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _repository.ToListAsync());
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
            LoadDropdown((E)Activator.CreateInstance(typeof(E)));
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
            LoadDropdown(entity);
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
            LoadDropdown(entity);
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
            LoadDropdown(entity);
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