using ConfigManager;
using System.Reflection.Metadata;

namespace ExaminationInfrastructure
{
    public class ExamResults
    {
        public string Division { get; set; }

        public List<SubjectResult> Results { get; set; }

        public ExamResults(List<string> input, string division, List<Subject> subjects) {
            this.Results = new List<SubjectResult>();
            this.Division = division;
            if(input.Count != subjects.Count)                        //situation when input or code changed inconsistenly
            {
                throw new Exception($"Count of exams for input string ({input.Count}) is not equal to count of exams ({subjects.Count})");
            }
            int i = 0;
            foreach (var sub in subjects)                           //we have exams same with the input order
            {
                this.Results.Add(new SubjectResult() { 
                    Exam = new Exam(sub.Name, sub.Division),                   
                    Score = int.Parse(input[i])                             //we checked format previously so just parsing
                });
                i++;
            }
        }

    }
}