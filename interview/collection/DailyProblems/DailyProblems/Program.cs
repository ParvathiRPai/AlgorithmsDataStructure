using Newtonsoft.Json;
using System;

namespace DailyProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileInput = System.IO.File.ReadAllText(@"../../../ManagerChart/input.json");

            var input = JsonConvert.DeserializeObject<Input>(fileInput);

            var managerChart = new ManagerChart();
            var result = managerChart.Run(input);
        }
    }
}
