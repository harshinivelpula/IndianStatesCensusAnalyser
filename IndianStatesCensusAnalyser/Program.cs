using IndianStatesCensusAnalyser;
namespace IndianStatesCensusAnalyserProgram
{
    class Program
    {
        public static string stateCensusCSVFilePath = @"C:\Users\DELL\source\repos\IndianStatesCensusAnalyser\IndianStatesCensusAnalyser\Files\StateCensusData.csv";
        public static string stateCodeCSVFilePth = @"C:\Users\DELL\source\repos\IndianStatesCensusAnalyser\IndianStatesCensusAnalyser\Files\StateCode.csv";
        public static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.Write("Enter the option :1.For State Census Date \n 2.For Indian State Code \n 3.Exit ");
                int option = Convert.ToInt16(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        CSVStateCensus cSVStateCensus = new CSVStateCensus();
                        cSVStateCensus.ReadStateCensusData(stateCensusCSVFilePath);
                        break;
                    case 2:
                        CSVStateCode cSVStateCode = new CSVStateCode();
                        cSVStateCode.ReadStateCodeData(stateCodeCSVFilePth);
                        break;
                    default:
                        flag = false;
                        break;
                }
            }
        }
    }
}