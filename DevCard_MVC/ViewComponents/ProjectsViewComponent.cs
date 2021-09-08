using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevCard_MVC.ViewComponents
{
    public class ProjectsViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var projects = new List<Project>()
            {
                new Project(1,"پروژه هوشمند سازی"," پروژه هوشمندسازی ویلا ها و آپارتمانهای بیشه کلا","هومن شیردل","/assets/images/project/project-1.jpg"),
                new Project(2,"پروژه محوطه سازی"," پروژه محوطه سازی ویلا ها و آپارتمانهای بیشه کلا","محمد نژاد","/assets/images/project/project-2.jpg"),
                new Project(3,"پروژه برج دو قلوی اردبیل"," پروژه اسکلت و زه کشی برجهای دوقلوی اردبیل","عطائی","/assets/images/project/project-3.jpg"),
                new Project(4,"پروژه هوشمند سازی"," پروژه بافت های فرسوده در تهران بزرگ منطقه شوش ساخت واحد های تجاری و اداری","باغ آذری","/assets/images/project/project-4.jpg")
            };
            return View("_Project", projects);
        }
    }
}
