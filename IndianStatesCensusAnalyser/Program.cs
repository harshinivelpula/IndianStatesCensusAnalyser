using IndianStatesCensusAnalyser;

namespace IndianStatesCensusAnalyserProgram
{
    class Program
    {
        public static string stateCensusCSVFilePath = @"C:\Users\DELL\source\repos\IndianStatesCensusAnalyser\IndianStatesCensusAnalyser\Files\StateCensusData.csv";        
        public static void Main(string[] args)
        {
            CSVStateCensus cSVStateCensus = new CSVStateCensus();
            cSVStateCensus.ReadStateCensusData(stateCensusCSVFilePath);
        }
    }
}