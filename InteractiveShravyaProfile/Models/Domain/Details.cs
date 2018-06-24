using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Domain
{
    public class Details
    {
        public string Name { get; set; }
        public string Email { get; set; }


        public  IEnumerable<Projects> ProjectsList{get;set;}

        public IEnumerable<Skills> SkillsCollection { get; set; }


    }


    public class Projects
    {
        public string ProjectName { get; set; }
        public string ProjectDescription { get; set; }

    }
    
    public class Skills
    {
        public string SkillsCategory { get; set; }
        public IEnumerable<string> SkillsList { get; set; }
    }
}
