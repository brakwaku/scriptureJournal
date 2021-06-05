using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RazorPagesScripture.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesScripture.Pages.Scriptures
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesScriptureContext _context;

        public IndexModel(RazorPagesScriptureContext context)
        {
            _context = context;
        }

        public IList<Scripture> Scripture { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList Notes { get; set; }
        [BindProperty(SupportsGet = true)]
        public string ScriptureNote { get; set; }

        public async Task OnGetAsync()
        {
            // Use LINQ to get list of genres.
            IQueryable<string> noteQuery = from m in _context.Scripture
                                           orderby m.Note
                                           select m.Note;
            var scriptures = from m in _context.Scripture
                             select m;
            if (!string.IsNullOrEmpty(SearchString))
            {
                scriptures = scriptures.Where(s => s.ScriptureRef.Contains(SearchString));
            }

            if (!string.IsNullOrEmpty(ScriptureNote))
            {
                scriptures = scriptures.Where(x => x.Note == ScriptureNote);
            }
            Notes = new SelectList(await noteQuery.Distinct().ToListAsync());

            Scripture = await scriptures.ToListAsync();
        }
    }
}
