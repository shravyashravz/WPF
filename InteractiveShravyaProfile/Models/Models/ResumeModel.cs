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



            if (skillsList.Count < 1)
            {
                skillsList = assignSkills();
            }
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

            skillsList.Add
              (
              "Windows Development",
              new List<string>(new string[]
              { "c#", "WPF", "xaml" }
              ));
            skillsList.Add
                (
                "Web Development",
                new List<string>(new string[]
                { "HTML","CSS","Java Script","Angular","Markdown" }
                ));
            skillsList.Add
               (
               "AI & Machine Learning",
               new List<string>(new string[]
               {"Regression", "SVM", "Random Forest",
 "Bayesian Methods", "K-Means", "Decision Trees",
"Time-Series Modelling", "Clustering, Matplotlib",
"Association Rule Learning", "Reinforcement Learning" }
               ));
            skillsList.Add
               (
               "Data Science and Analytical Tools",
               new List<string>(new string[]
               { "Python","SSIS","SSRS","SSAS","Weka","Power BI","Qualtrics" }
               ));
           
            skillsList.Add
              (
              "Database",
              new List<string>(new string[]
              { "Oracle","MS SQL SERVER","Microsoft Visio","T SQL","PostGre SQL","SQL LITE3" }
              ));
            skillsList.Add
              (
              "Version Control",
              new List<string>(new string[]
              { "TFS","Git Hub","Bit Bucket" }
              ));

            return skillsList;
        }
    }
}
