using Microsoft.AspNetCore.Mvc;
using System;
using DevCard_MVC.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevCard_MVC.ViewComponents
{
    public class ArticlesViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var articles = new List<Article>
            {
                new Article(1,"هوشمند سازی",
                              "راحتی، آسایش و آرامش را برای خانه و محل کار خود فراهم کنید"
                              ,"assets/images/blog/blog-post-thumb-card-1.jpg"),
                               new Article(1,"زهکشی آبهای سطحی",
                              "در پروژه های ساختمانی میبایست آبهای سطحی جمع آوری گردد"
                              ,"assets/images/blog/blog-post-thumb-card-2.jpg"),
                               new Article(1,"برج باغ ها",
                              "راحتی، آسایش و آرامش را برای خانه و محل کار خود فراهم کنید"
                              ,"assets/images/blog/blog-post-thumb-card-3.jpg"),


            };
            return View("_Article",articles);
        }
    }
}
