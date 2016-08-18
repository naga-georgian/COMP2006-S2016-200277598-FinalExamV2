using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using COMP2006_S2016_FinalExamV2.Models;
using System.Data.Entity;
using System.Threading.Tasks;
//Naga Rimmalapudi 200277598    
// ListPagesController
//Final Exam
namespace COMP2006_S2016_FinalExamV2.Controllers
{
    public class ListPagesController : Controller
    {
        private MVCMusicStoreContext db = new MVCMusicStoreContext();
        // GET: ListPages
        public async Task<ActionResult> Album()
        {
            return View(await db.Albums.ToListAsync());
        }
        public async Task<ActionResult> Artist()
        {
            return View(await db.Artists.ToListAsync());
        }
        public async Task<ActionResult> Genre()
        {
            return View(await db.Genres.ToListAsync());
        }
    }
}