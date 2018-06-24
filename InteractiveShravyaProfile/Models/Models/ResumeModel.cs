using Models.Domain;
using Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class ResumeModel : IResumeModel
    {

        public Details GetDetails()
        {
            Details details = new Details();
            details.Name = "Shravya Boini";
            details.Email = "shravya.boini@mnsu.edu";
            details.SkillsCollection = GetSkills();
            return details;
        }


        Dictionary<string, List<string>> skillsList = new Dictionary<string, List<string>>();
     
        public IEnumerable<Skills> GetSkills()
        {

            


            skillsList = assignSkills();
            foreach (KeyValuePair<string, List<string>> entry in skillsList)
            {
                yield return new Skills
                {
                    SkillsCategory = entry.Key,
                    SkillsList = entry.Value
                };
            }
        }


        //Dictionary to fill in all the skills aquired
        private Dictionary<string, List<string>> assignSkills()
        {
            skillsList.Add("Web Technologies", new List<string>(new string[] { "element1", "element2", "element3" }));
            skillsList.Add("Web Technologies2", new List<string>(new string[] { "element1", "element2", "element3" }));
            skillsList.Add("Web Technologies3", new List<string>(new string[] { "element1", "element2", "element3" }));
            skillsList.Add("Web Technologies4", new List<string>(new string[] { "element1", "element2", "element3" }));

            return skillsList;
        }
    }
}
