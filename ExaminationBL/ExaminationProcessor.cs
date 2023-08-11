using ConfigManager;
using ExaminationInfrastructure;
using System.Globalization;
using System.Text.RegularExpressions;

namespace ExaminationBL
{
    public class ExaminationProcessor : IExaminationProcessor
    {
        public int GetPassedCount(string input)
        {
            //parse and get well typed list of results
            List<ExamResults> results = ParseExamResults(input);
            int numberPassed = 0;
            foreach (ExamResults result in results)
            {
                if( CheckPersonPassed(result, result.Division, ConfigClass.DivisionTypes.Single(x=>x.Name==result.Division).MinimumScore))
                    numberPassed++;
            }
            return numberPassed;
        }

        List<ExamResults> ParseExamResults(string input)
        {
            List<string> inputList = input.Split("\n").ToList();
            List<ExamResults> results = new List<ExamResults>();
          
            if(inputList.Any()                                                              //check if any data       
                && 
                Regex.IsMatch(inputList.First().ToString().Trim(), @"\d+")                  //check if first line is count of people
                &&
                inputList.Count - 1 == int.Parse(inputList.First()))                        //check if count number in first line the same with the lines count
            {
                inputList.RemoveAt(0);
            }
            else
            {
                throw new Exception("Input string has incorrect format:" + input);
            }
            foreach (string line in inputList)
            {                                                                               //check if we have format like 't_1 e_1 m_1 s_1 j_1 g_1'

                if (!Regex.IsMatch(line, @"["+ConfigClass.GetDivisionsCodes()+@"](\s(([0-9][0-9])|[0-9]|100)){"+ConfigClass.Subjects.Count+"}"))           
                {
                    throw new Exception("Input string has incorrect format:" + line);
                }
                var splited = line.Split(' ').ToList();
                var division = splited[0].Trim();
                splited.RemoveAt(0);
                if (ConfigClass.DivisionTypes.Any(x => x.InputValue == division))
                    division = ConfigClass.DivisionTypes.Single(x => x.InputValue == division).Name;
                else
                    throw new Exception($"Division {division} is not defined in configuration");
                results.Add(new ExamResults(splited,division, ConfigClass.Subjects));       //create object of results for each person
            }
            return results;
        }

        bool CheckPersonPassed(ExamResults result, string type, int specificScore)
        {
            //calculate subjects score
            var scoreSum = result.Results.Where(x => x.Exam.DivisionType == type).Sum(x => x.Score);
            var totalScore = result.Results.Sum(x => x.Score);
            if (scoreSum >= specificScore && totalScore >= ConfigClass.MinimalTotalScore)
            {
                return true;
            }
            return false;
        }
        
    }
}