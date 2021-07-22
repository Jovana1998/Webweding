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
    public class AdminPregledOrganizatoraModel : PageModel
    {
        private readonly WebWedding.WebWeddingContext _context;
        public bool parse { get; set; }
        [BindProperty]
        public int AdminID { get; set; }
        public AdminPregledOrganizatoraModel(WebWedding.WebWeddingContext context)
        {
            _context = context;
        }

        public IList<Organizator> Organizator { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            parse = int.TryParse(HttpContext.Session.GetString("idAdmin"), out int idAdmin);
            if (parse)
            {
                AdminID = idAdmin;
                Organizator = await _context.Organizatori.Where(x=>x.Arhivirano==false || x.Arhivirano==null).ToListAsync();
                return Page();
            }
            else return RedirectToPage("../Index");
        }
    }
}