﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NetFinal.Data;
using NetFinal.Models;
using NetFinal.Services;

namespace NetFinal.Controllers
{
    public class PartnersController : Controller
    {
        private readonly NetFinalContext _context;

        public PartnersController(NetFinalContext context)
        {
            _context = context;
        }

        /*private readonly PartnersService _partnersService;

        public PartnersController(PartnersService partnersService)
        {
            _partnersService = partnersService;
        }
        // GET: Partners
        public async Task<IActionResult> Index()
        {
            var partners = await _partnersService.GetPartners();
            return View(partners);
        }*/

        // GET: Partners
        public async Task<IActionResult> Index()
        {
            return View(await _context.Partners.ToListAsync());
        }

        // GET: Partners/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var partners = await _context.Partners
                .FirstOrDefaultAsync(m => m.PartnerID == id);
            if (partners == null)
            {
                return NotFound();
            }

            return View(partners);
        }

        // GET: Partners/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Partners/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PartnerID,CompanyName,Description,Link")] Partners partners)
        {
            if (ModelState.IsValid)
            {
                _context.Add(partners);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(partners);
        }

        // GET: Partners/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var partners = await _context.Partners.FindAsync(id);
            if (partners == null)
            {
                return NotFound();
            }
            return View(partners);
        }

        // POST: Partners/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PartnerID,CompanyName,Description,Link")] Partners partners)
        {
            if (id != partners.PartnerID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(partners);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PartnersExists(partners.PartnerID))
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
            return View(partners);
        }

        // GET: Partners/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var partners = await _context.Partners
                .FirstOrDefaultAsync(m => m.PartnerID == id);
            if (partners == null)
            {
                return NotFound();
            }

            return View(partners);
        }

        // POST: Partners/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var partners = await _context.Partners.FindAsync(id);
            _context.Partners.Remove(partners);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PartnersExists(int id)
        {
            return _context.Partners.Any(e => e.PartnerID == id);
        }
    }
}
