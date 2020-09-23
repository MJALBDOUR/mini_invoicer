﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MiniInvoicer.Data;
using MiniInvoicer.Models;

namespace MiniInvoicer.Pages.Receipts
{
    public class DetailsModel : PageModel
    {
        private readonly MiniInvoicer.Data.ApplicationDbContext _context;

        public DetailsModel(MiniInvoicer.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Receipt Receipt { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Receipt = await _context.Receipt.FirstOrDefaultAsync(m => m.ReceiptID == id);

            if (Receipt == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
