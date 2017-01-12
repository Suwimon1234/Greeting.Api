
using Microsoft.AspNetCore.Mvc;
using WebApplication.Data;
using System.Linq;
using System;

namespace src.Controllers
{
    public class VocabController : Controller
    {
        ApplicationDbContext db;

        public VocabController(ApplicationDbContext db)
        {
            this.db = db;
        }
        
        public IActionResult GetByAlphabet(string alphabet)
        {
            return Ok(db.Vocabularies
                        .Where(x => x.Alphabet == alphabet)
                        .OrderBy(x => Guid.NewGuid())
                        .Take(1));
        }
    }
}