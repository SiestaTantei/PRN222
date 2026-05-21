using Manga.Entites.ThinhPH.Models;
using Manga.Repositories.ThinhPH.DBContext;
using Manga.Services.ThinhPH;
using Manga.Services.ThinhPH.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Manga.WebMVCApp.ThinhPH.Controllers
{
    public class ContractMasterThinhPhsController : Controller
    {
        private readonly IContractMasterThinhPhService _contractMasterThinhPhService;

        public ContractMasterThinhPhsController(IContractMasterThinhPhService contractMasterThinhPhService)
        {
            _contractMasterThinhPhService = contractMasterThinhPhService;
        }

        // GET: ContractMasterThinhPhs
        public async Task<IActionResult> Index()
        {
           var contractMasterThinhPhs = await _contractMasterThinhPhService.GetAllsAsync();
            return View(contractMasterThinhPhs);
        }

        // GET: ContractMasterThinhPhs/Details/5
        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var contractMasterThinhPh = await _context.ContractMasterThinhPhs
        //        .Include(c => c.Series)
        //        .FirstOrDefaultAsync(m => m.ContractIdThinhPh == id);
        //    if (contractMasterThinhPh == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(contractMasterThinhPh);
        //}

        //// GET: ContractMasterThinhPhs/Create
        //public IActionResult Create()
        //{
        //    ViewData["SeriesId"] = new SelectList(_context.MangaSeries, "SeriesId", "Title");
        //    return View();
        //}

        //// POST: ContractMasterThinhPhs/Create
        //// To protect from overposting attacks, enable the specific properties you want to bind to.
        //// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("ContractIdThinhPh,SeriesId,SignDate,BaseRoyaltyRate,ContractTerms,IsExclusive")] ContractMasterThinhPh contractMasterThinhPh)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(contractMasterThinhPh);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    ViewData["SeriesId"] = new SelectList(_context.MangaSeries, "SeriesId", "Title", contractMasterThinhPh.SeriesId);
        //    return View(contractMasterThinhPh);
        //}

        //// GET: ContractMasterThinhPhs/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var contractMasterThinhPh = await _context.ContractMasterThinhPhs.FindAsync(id);
        //    if (contractMasterThinhPh == null)
        //    {
        //        return NotFound();
        //    }
        //    ViewData["SeriesId"] = new SelectList(_context.MangaSeries, "SeriesId", "Title", contractMasterThinhPh.SeriesId);
        //    return View(contractMasterThinhPh);
        //}

        //// POST: ContractMasterThinhPhs/Edit/5
        //// To protect from overposting attacks, enable the specific properties you want to bind to.
        //// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("ContractIdThinhPh,SeriesId,SignDate,BaseRoyaltyRate,ContractTerms,IsExclusive")] ContractMasterThinhPh contractMasterThinhPh)
        //{
        //    if (id != contractMasterThinhPh.ContractIdThinhPh)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(contractMasterThinhPh);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!ContractMasterThinhPhExists(contractMasterThinhPh.ContractIdThinhPh))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    ViewData["SeriesId"] = new SelectList(_context.MangaSeries, "SeriesId", "Title", contractMasterThinhPh.SeriesId);
        //    return View(contractMasterThinhPh);
        //}

        //// GET: ContractMasterThinhPhs/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var contractMasterThinhPh = await _context.ContractMasterThinhPhs
        //        .Include(c => c.Series)
        //        .FirstOrDefaultAsync(m => m.ContractIdThinhPh == id);
        //    if (contractMasterThinhPh == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(contractMasterThinhPh);
        //}

        //// POST: ContractMasterThinhPhs/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var contractMasterThinhPh = await _context.ContractMasterThinhPhs.FindAsync(id);
        //    if (contractMasterThinhPh != null)
        //    {
        //        _context.ContractMasterThinhPhs.Remove(contractMasterThinhPh);
        //    }

        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        //private bool ContractMasterThinhPhExists(int id)
        //{
        //    return _context.ContractMasterThinhPhs.Any(e => e.ContractIdThinhPh == id);
        //}
    }
}
