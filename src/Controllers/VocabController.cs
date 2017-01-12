
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
        
        public IQueryable<Vocabulary> GetByAlphabet(string alphabet)
        {
            return db.Vocabularies
                        .Where(x => x.Alphabet == alphabet)
                        .OrderBy(x => Guid.NewGuid());
        }

        public IQueryable<Vocabulary> GetByAll()
        {
            return db.Vocabularies
                        .OrderBy(x => Guid.NewGuid());
        }
    }
}