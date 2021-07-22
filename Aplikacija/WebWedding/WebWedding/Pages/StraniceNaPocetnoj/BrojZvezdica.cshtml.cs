using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace WebWedding.Pages.StraniceNaPocetnoj
{
    public class BrojZvezdicaModel : PageModel
    {
        public WebWeddingContext _db { get; set; }
        [BindProperty]
        public bool parse { get; set; }

        [BindProperty]
        public int Broj { get; set; }

        public bool ImaVecZahtev { get; set; }

        [BindProperty]
        public int ID { get; set; }
        [BindProperty]
        public int KorisnikID { get; set; }

        public BrojZvezdicaModel(WebWeddingContext db)
        {
            _db = db;
        }
        public async Task<IActionResult> OnGetAsync(int id)
        {
            parse = int.TryParse(HttpContext.Session.GetString("idKorisnik"), out int idKorisnik);
            if (parse)
            {
                KorisnikID = idKorisnik;
                Korisnik korisnik = await _db.Korisnici.FindAsync(idKorisnik);
                Zahtev MojZahtev = await _db.Zahtevi.Where(x => x.MojKorisnik == korisnik).FirstOrDefaultAsync();
                if (MojZahtev == null)
                {
                    ImaVecZahtev = false;
                }
                else
                {
                    ImaVecZahtev = true;
                }

                return Page();
            }
            else
            {
                return RedirectToPage("../Index");
            }
        }
        public async Task<IActionResult> OnPostIzracunajAsync()
        {
            parse = int.TryParse(HttpContext.Session.GetString("idKorisnik"), out int idKorisnik);
            if (parse)
            {
                KorisnikID = idKorisnik;
                var korisnik = await _db.Korisnici.FindAsync(idKorisnik);
                var pom = await _db.Korisnici.Include(x => x.MojZahtev).FirstOrDefaultAsync();
                var pom1 = await _db.Zahtevi.Include(x => x.MojProstor).FirstOrDefaultAsync();
                var pom2 = await _db.Prostori.Where(x => x.Id == pom1.MojProstor.Id).FirstOrDefaultAsync();

                if ( pom2.Id == ID)
                {
                    var prostor = await _db.Prostori.FindAsync(ID);
                    if ((prostor.BrojZvezdica + Broj) / 2 < 5)
                    {
                        prostor.BrojZvezdica = (prostor.BrojZvezdica + Broj) / 2;
                    }
                    else
                    {
                        prostor.BrojZvezdica = 5;
                    }
                    await _db.SaveChangesAsync();

                }
                return RedirectToPage("../StraniceNaPocetnoj/PrikazProstor");
            }
            return RedirectToPage("../Index");
        }
        

    }
}
