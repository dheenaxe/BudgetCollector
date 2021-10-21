using BudgetCollector.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BudgetCollector.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            string Date = DateTime.Today.Day.ToString() + "." + DateTime.Today.Month.ToString() + "." + DateTime.Today.Year.ToString();
            ViewBag.Date = Date;
            using (var context = new Context())
            {
                List<Budget> secilmis = new List<Budget>();
                foreach (var item in context.Budgets)
                {
                    if (item.Time.Day == DateTime.Now.Day && item.Time.Month == DateTime.Now.Month && item.Time.Year == DateTime.Now.Year)
                    {
                        secilmis.Add(item);
                    }
                }
                return View(secilmis.ToList());
            }
        }

        [HttpGet]
        [ActionName("Create")]
        public ActionResult Create_Get(Budget budget)
        {
            return View();
        }

        [HttpPost]
        [ActionName("Create")]
        public ActionResult Create_Post(Budget budget)
        {
            using (var context = new Context())
            {
                budget.Time = DateTime.Now;
                context.Budgets.Add(budget);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
        }

        [HttpGet]
        [ActionName("Register")]
        public ActionResult Register_Get()
        {
            return View();
        }

        [HttpPost]
        [ActionName("Register")]
        public ActionResult Register_Post(Account account)
        {
            using (var context = new Context())
            {
                context.Accounts.Add(account);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
        }

        [HttpGet]
        [ActionName("Login")]
        public ActionResult Login_Get()
        {
            return View();
        }

        [HttpPost]
        [ActionName("Login")]
        public ActionResult Login_Post(Account account)
        {
            using (var context = new Context())
            {
                foreach (var item in context.Accounts)
                {
                    if (account.nickname == item.nickname && account.password == item.password)
                    {
                        ViewBag.Giris = "Giriş Yapabildiniz.";
                    }

                    else
                    {
                        ViewBag.Giris = "Giriş Yapılamadı.";
                    }
                }
                return View();
            }
        }

        public ActionResult ListKategori()
        {
            using (var context = new Context())
            {
                List<Category> categories = context.Categories.ToList();
                return View(categories);
            }
        }

        [HttpGet]
        [ActionName("KategoriEkle")]
        public ActionResult KategoriEkle_Get()
        {
            return View();
        }

        [HttpPost]
        [ActionName("KategoriEkle")]
        public ActionResult KategoriEkle_Post(Category category)
        {
            using (var context = new Context())
            {
                context.Categories.Add(category);
                context.SaveChanges();
                return RedirectToAction("ListKategori");
            }
        }
    }
}