using ClosedXML.Excel;
using CoreDemo.Areas.Admin.Models;
using CoreDemo.Models;
using DataAccessLayer.Context;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ExcellExportBlogList()
        {
            using (var workbook = new XLWorkbook())
            {
                var workSheet = workbook.AddWorksheet("Blog Listesi");
                workSheet.Cell(1, 1).Value = "Blog ID";
                workSheet.Cell(1, 2).Value = "Blog Adı";
                int blogRowCount = 2;
                foreach (var item in GetBlogList())
                {
                    workSheet.Cell(blogRowCount, 1).Value = item.Id;
                    workSheet.Cell(blogRowCount, 2).Value = item.BlogName;
                    blogRowCount++;
                }
                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officaldocument.spreadsheetml.sheet", "Calisma1.xlsx");

                }
            }

        }

        public static List<BlogModel1> GetBlogList()
        {
            List<BlogModel1> blogs = new List<BlogModel1>()
            {
                new BlogModel1(){ Id=1,BlogName="Orxan"},
                new BlogModel1(){ Id=2,BlogName="Sadiq"},
                new BlogModel1(){ Id=3,BlogName="Ayxan"}
            };
            return blogs;
        }

        public IActionResult ExcellExportDynamicBlogList()
        {

            using (var workBook = new XLWorkbook())
            {
                var workSheet = workBook.Worksheets.Add("Blog Listesi");
                workSheet.Cell(1, 1).Value = "Blog Id";
                workSheet.Cell(1, 2).Value = "Blog Adı";

                int blogRowCount = 2;
                foreach (var item in GetListBlogFromDatabase())
                {

                    workSheet.Cell(blogRowCount, 1).Value = item.Id;
                    workSheet.Cell(blogRowCount, 2).Value = item.BlogName;
                    blogRowCount++;
                }
                using(var stream=new MemoryStream())
                {
                    workBook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officaldocument.spreadsheetml.sheet", "Calisma2.xlsx");
                }
            }


        }

        public IActionResult ExcelExportDatabase()
        {
            return View();
        }
        public List<BlogModel2> GetListBlogFromDatabase()
        {
            List<BlogModel2> bm = new List<BlogModel2>();
            using (var context = new CoreContext())
            {
                bm = context.Blogs.Select(p => new BlogModel2()
                {
                    Id = p.BlogID,
                    BlogName = p.BlogTitle
                }).ToList();
            }
            return bm;
        }
    }
}
