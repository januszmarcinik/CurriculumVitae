using CurriculumVitae.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace CurriculumVitae.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var model = new CurriculumVitaeViewModel()
            {
                ProgrammingLanguages = new SkillsSet()
                {
                    Head = "Języki programowania",
                    Icon = "fa fa-fw fa-keyboard-o",
                    Skills = new List<Skill>()
                    {
                        new Skill() { Name = "C#", Range = 4.0 },
                        new Skill() { Name = "SQL", Range = 3.0 },
                        new Skill() { Name = "JavaScript", Range = 3.0 },
                    }
                },
                NETTechnologies = new SkillsSet()
                {
                    Head = "Technologie .NET",
                    Icon = "fa fa-fw fa-microchip",
                    Skills = new List<Skill>()
                    {
                        new Skill() { Name = "ASP.NET MVC 5", Range = 4.5 },
                        new Skill() { Name = "Windows Forms", Range = 3.5 },
                        new Skill() { Name = "Web API", Range = 3.0 },
                    }
                },
                BackEnd = new SkillsSet()
                {
                    Head = "Narzędzia BACK-END",
                    Icon = "fa fa-fw fa-cogs",
                    Skills = new List<Skill>()
                    {
                        new Skill() { Name = "LINQ", Range = 4.0 },
                        new Skill() { Name = "Entity Framework", Range = 3.5 },
                        new Skill() { Name = "Microsoft Identity", Range = 3.0 },
                    }
                },
                FrontEnd = new SkillsSet()
                {
                    Head = "Narzędzia FRONT-END",
                    Icon = "fa fa-fw fa-paint-brush",
                    Skills = new List<Skill>()
                    {
                        new Skill() { Name = "HTML", Range = 3.5 },
                        new Skill() { Name = "CSS + Bootstrap", Range = 3.5 },
                        new Skill() { Name = "JQuery", Range = 3.0 },
                        new Skill() { Name = "Telerik Kendo UI", Range = 2.5 },
                    }
                },
                ForeignLanguages = new SkillsSet()
                {
                    Head = "Języki obce",
                    Icon = "fa fa-fw fa-language",
                    Skills = new List<Skill>()
                    {
                        new Skill() { Name = "Język angielski", Range = 4.0 },
                        new Skill() { Name = "Język niemiecki", Range = 2.0 },
                    }
                },
                Personal = new SkillsSet()
                {
                    Head = "Cechy osobowe",
                    Icon = "fa fa-fw fa-user",
                    Skills = new List<Skill>()
                    {
                        new Skill() { Name = "Kreatywność", Range = 5.0 },
                        new Skill() { Name = "Organizacja pracy", Range = 4.5 },
                        new Skill() { Name = "Komunikatywność", Range = 4.5 },
                        new Skill() { Name = "Odporność na stres", Range = 4.0 },
                        new Skill() { Name = "Punktualność", Range = 4.0 },
                    }
                },
            };

            return View(model);
        }
    }
}