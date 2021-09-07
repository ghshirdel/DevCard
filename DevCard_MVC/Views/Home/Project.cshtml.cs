using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DevCard_MVC.Data;
using DevCard_MVC.Models;

namespace DevCard_MVC.Views.Home
{
    public class ProjectModel : PageModel
    {
        private readonly DevCard_MVC.Data.DevCard_MVCContext _context;

        public ProjectModel(DevCard_MVC.Data.DevCard_MVCContext context)
        {
            _context = context;
        }

        public IList<Project> Project { get;set; }

        public async Task OnGetAsync()
        {
            Project = await _context.Project.ToListAsync();
        }
    }
}
