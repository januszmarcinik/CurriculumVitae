using System.Collections.Generic;

namespace CurriculumVitae.Models
{
    public class CurriculumVitaeViewModel
    {
        public SkillsSet ProgrammingLanguages { get; set; }
        public SkillsSet NETTechnologies { get; set; }
        public SkillsSet WorkTools { get; set; }
        public SkillsSet BackEnd { get; set; }
        public SkillsSet FrontEnd { get; set; }
        public SkillsSet ForeignLanguages { get; set; }
        public SkillsSet Personal { get; set; }

        public CurriculumVitaeViewModel(LangVersion lang)
        {
            ProgrammingLanguages = new SkillsSet()
            {
                Head = lang == LangVersion.PL ? "Języki Programowania" : "Programming Languages",
                Icon = "fa fa-fw fa-keyboard-o",
                Skills = new List<Skill>()
                {
                    new Skill() { Name = "C#", Range = 4.0 },
                    new Skill() { Name = "SQL", Range = 3.0 },
                    new Skill() { Name = "JavaScript", Range = 3.0 },
                }
            };
            NETTechnologies = new SkillsSet()
            {
                Head = lang == LangVersion.PL ? "Technologie .NET" : ".NET Technologies",
                Icon = "fa fa-fw fa-microchip",
                Skills = new List<Skill>()
                {
                    new Skill() { Name = "ASP.NET MVC 5", Range = 4.5 },
                    new Skill() { Name = "Web API", Range = 3.5 },
                    new Skill() { Name = "Windows Forms", Range = 3.5 },
                }
            };
            BackEnd = new SkillsSet()
            {
                Head = lang == LangVersion.PL ? "Narzędzia BACK-END" : "BACK-END Tools",
                Icon = "fa fa-fw fa-cogs",
                Skills = new List<Skill>()
                {
                    new Skill() { Name = "LINQ", Range = 4.0 },
                    new Skill() { Name = "Entity Framework", Range = 3.5 },
                }
            };
            FrontEnd = new SkillsSet()
            {
                Head = lang == LangVersion.PL ? "Narzędzia FRONT-END" : "FRONT-END Tools",
                Icon = "fa fa-fw fa-paint-brush",
                Skills = new List<Skill>()
                {
                    new Skill() { Name = "HTML", Range = 3.5 },
                    new Skill() { Name = "CSS + Bootstrap", Range = 3.5 },
                    new Skill() { Name = "JQuery", Range = 3.0 },
                    new Skill() { Name = "Telerik Kendo UI", Range = 2.5 },
                }
            };

            if (lang == LangVersion.PL)
            {
                ForeignLanguages = new SkillsSet()
                {
                    Head = "Języki Obce",
                    Icon = "fa fa-fw fa-language",
                    Skills = new List<Skill>()
                    {
                        new Skill() { Name = "Język angielski", Range = 3.0 },
                        new Skill() { Name = "Język niemiecki", Range = 1.5 },
                    }
                };
            }
            else
            {
                ForeignLanguages = new SkillsSet()
                {
                    Head = "Foreign Languages",
                    Icon = "fa fa-fw fa-language",
                    Skills = new List<Skill>()
                    {
                        new Skill() { Name = "English", Range = 3.0 },
                        new Skill() { Name = "German", Range = 1.5 },
                    }
                };
            }

            if (lang == LangVersion.PL)
            {
                Personal = new SkillsSet()
                {
                    Head = "Cechy Osobowe",
                    Icon = "fa fa-fw fa-user",
                    Skills = new List<Skill>()
                    {
                        new Skill() { Name = "Kreatywność", Range = 5.0 },
                        new Skill() { Name = "Organizacja pracy", Range = 4.5 },
                        new Skill() { Name = "Komunikatywność", Range = 4.5 },
                        new Skill() { Name = "Odporność na stres", Range = 4.0 },
                        new Skill() { Name = "Punktualność", Range = 4.0 },
                    }
                };
            }
            else
            {
                Personal = new SkillsSet()
                {
                    Head = "Personal Features",
                    Icon = "fa fa-fw fa-user",
                    Skills = new List<Skill>()
                    {
                        new Skill() { Name = "Creativity", Range = 5.0 },
                        new Skill() { Name = "Orderly", Range = 4.5 },
                        new Skill() { Name = "Communicativeness", Range = 4.5 },
                        new Skill() { Name = "Immunity on stress", Range = 4.0 },
                        new Skill() { Name = "Punctuality", Range = 4.0 },
                    }
                };
            }
        }
    }
}