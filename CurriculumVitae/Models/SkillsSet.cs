using System.Collections.Generic;

namespace CurriculumVitae.Models
{
    public class SkillsSet
    {
        public string Head { get; set; }
        public string Icon { get; set; }

        public List<Skill> Skills { get; set; }
    }
}