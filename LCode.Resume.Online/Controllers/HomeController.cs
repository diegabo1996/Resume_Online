using LCode.Resume.Online.DataBase.Contextos.v1_0;
using LCode.Resume.Online.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace LCode.Resume.Online.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly Contexto _contexto = new Contexto();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> IndexAsync()
        {
            string lang = Request.Query["lang"].ToString();
            var userLangs = Request.Headers["Accept-Language"].ToString();
            var firstLang = userLangs.Split(',').FirstOrDefault();
            var defaultLang = string.IsNullOrEmpty(firstLang) ? "en" : firstLang.Split('-')[0];
            if (!string.IsNullOrEmpty(lang))
            {
                defaultLang = lang;
            }
            Guid Guid_Resume = new Guid("D479B00F-8803-4704-926A-496666803E6B");
            GeneralModel generalModel = new GeneralModel();
            generalModel.CultureResume = await _contexto.Culture_Resume.Where(x => x.Guid_Resume == Guid_Resume && x.Enable).ToListAsync();
            var Guid_Resume_Culture = generalModel.CultureResume.FirstOrDefault(x => x.Culture_Code == defaultLang);
            if (Guid_Resume_Culture==null)
            {
                Guid_Resume_Culture = generalModel.CultureResume.FirstOrDefault();
            }
            ViewData["Culture"] = Guid_Resume_Culture.Culture_Code;
            ViewData["URLSite"] = Request.Scheme+"://"+ Request.Host+ Request.Path;
            generalModel.General_Information = await _contexto.General_Information.FindAsync(Guid_Resume);
            generalModel.Social_Networks = _contexto.Social_Networks.Where(x=>x.Guid_Resume==Guid_Resume&&x.Guid_Culture_Resume==Guid_Resume_Culture.Guid_Culture_Resume).ToList();
            generalModel.Resume_Section = _contexto.Resume_Section.Where(x => x.Guid_Resume == Guid_Resume && x.Guid_Culture_Resume == Guid_Resume_Culture.Guid_Culture_Resume).OrderByDescending(x=>x.DateStart).ToList();
            generalModel.WhatIDo = _contexto.WhatIDo.Where(x => x.Guid_Resume == Guid_Resume && x.Guid_Culture_Resume == Guid_Resume_Culture.Guid_Culture_Resume).ToList();
            generalModel.Resume_Knowledge_General = _contexto.Resume_Knowledge_General.Where(x => x.Guid_Resume == Guid_Resume && x.Guid_Culture_Resume == Guid_Resume_Culture.Guid_Culture_Resume).OrderBy(x => x.DateTimeCreated).ToList();
            var Resume_Extra_Skills = _contexto.Resume_Extra_Skills.Where(x => x.Guid_Resume == Guid_Resume && x.Guid_Culture_Resume == Guid_Resume_Culture.Guid_Culture_Resume).ToList();
            generalModel.Resume_Extra_Skills_Groups = Resume_Extra_Skills.AsParallel().ToLookup(x => x.Skill_Title).ToList();
            var Portfolio = _contexto.Portfolio.Where(x => x.Guid_Resume == Guid_Resume && x.Guid_Culture_Resume == Guid_Resume_Culture.Guid_Culture_Resume).Include(x => x.Category_Portfolio).ToList();
            generalModel.Portfolio_Group= Portfolio.AsParallel().ToLookup(x => x.Category_Portfolio).ToList();
            generalModel.Personal_Titles = _contexto.Personal_Titles.Where(x => x.Guid_Resume == Guid_Resume && x.Guid_Culture_Resume == Guid_Resume_Culture.Guid_Culture_Resume).ToList();
            generalModel.About_Info = await _contexto.About_Info.FirstOrDefaultAsync(x=>x.Guid_Resume==Guid_Resume && x.Guid_Culture_Resume == Guid_Resume_Culture.Guid_Culture_Resume);
            return View(Guid_Resume_Culture.Culture_Code, generalModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
