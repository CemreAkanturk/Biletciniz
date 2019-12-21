using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Biletciniz.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Biletciniz.Pages
{
    public class IndexModel : PageModel
    {

        private readonly Biletciniz.Data.ApplicationDbContext _db;
        public IndexModel(Biletciniz.Data.ApplicationDbContext db)
        {
            _db = db;
        }

     
    
        public void OnGet()
        {
        
        }
    }
}
