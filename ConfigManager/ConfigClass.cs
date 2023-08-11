using AutoMapper.Configuration;
using Microsoft.Extensions.Configuration;
using System.Linq;

namespace ConfigManager
{
    static public class ConfigClass
    {
        static string DivisionConfigName = "Divisions";
        static string SubjectsConfigName = "Subjects";
        static string MinimalTotalScoreName = "MinimalTotalScore";

        public static int MinimalTotalScore;

        public static List<Subject> Subjects { get; }
        public static List<DivisionType> DivisionTypes { get; }

        static ConfigClass()
        {
            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "jsconfig.json"))
                .Build();

            Subjects = config.GetSection(SubjectsConfigName).Get<List<Subject>>(
                options =>
                {
                    options.BindNonPublicProperties = true;
                    options.ErrorOnUnknownConfiguration = false;
                });

            DivisionTypes = config.GetSection(DivisionConfigName).Get<List<DivisionType>>(
                options =>
                {
                    options.BindNonPublicProperties = true;
                    options.ErrorOnUnknownConfiguration = false;
                });

            MinimalTotalScore = config.GetValue<int>(MinimalTotalScoreName);
        }

        public static string GetDivisionsCodes()
        {
            return String.Join("",DivisionTypes.Select(x => x.InputValue));
        }
    }
}