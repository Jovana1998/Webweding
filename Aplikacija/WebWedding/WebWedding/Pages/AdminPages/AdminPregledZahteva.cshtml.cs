﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace WebWedding
{
    public class AdminPregledZahtevaModel : PageModel
    {
        private readonly WebWedding.WebWeddingContext _context;
        public bool parse { get; set; }
        [BindProperty]
        public int AdminID { get; set; }
        public AdminPregledZahtevaModel(WebWedding.WebWeddingContext context)
        {
            _context = context;
        }

        public IList<Zahtev> Zahtevi { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            parse = int.TryParse(HttpContext.Session.GetString("idAdmin"), out int idAdmin);
            if (parse)
            {
                AdminID = idAdmin;
                Zahtevi = await _context.Zahtevi
                .Include(x => x.MojKorisnik).Include(x => x.MojProstor)
                .Include(x => x.MojFotograf).Include(x => x.MojMeni)
                .Include(x => x.MojaMuzika)
                .Include(x => x.MojaDekoracija).Where(x=>x.Arhivirano==false || x.Arhivirano==null).ToListAsync(); //prikazuje samo nearhivirane zahteve
                return Page();
            }
            else return RedirectToPage("../Index");
        }
    }
}