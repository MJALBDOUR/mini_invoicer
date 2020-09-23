﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MiniInvoicer.Data;
using MiniInvoicer.Models;

namespace MiniInvoicer.Pages.InvoiceProducts
{
    public class DeleteModel : PageModel
    {
        private readonly MiniInvoicer.Data.ApplicationDbContext _context;

        public DeleteModel(MiniInvoicer.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public InvoiceProduct InvoiceProduct { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            InvoiceProduct = await _context.InvoiceProduct.FirstOrDefaultAsync(m => m.InvoiceProductID == id);

            if (InvoiceProduct == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            InvoiceProduct = await _context.InvoiceProduct.FindAsync(id);

            if (InvoiceProduct != null)
            {
                _context.InvoiceProduct.Remove(InvoiceProduct);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}