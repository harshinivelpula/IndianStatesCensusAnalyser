using IndianStatesCensusAnalyser;

namespace IndianStateCensusTest
{
    public class Tests
    {
        public static string stateCensusCSVFilePath = @"C:\Users\DELL\source\repos\IndianStatesCensusAnalyser\IndianStatesCensusAnalyser\Files\StateCensusData.csv";

        [Test]
        public void GivenStateCensusData_WhenAnalyse_ShoulReturnNumberOfRecordMatches()
        {
            StateCodeAnalyser stateCodeAnalyser = new StateCodeAnalyser();
            CSVStateCensus cSVStateCensus = new CSVStateCensus();
            Assert.AreEqual(cSVStateCensus.ReadStateCensusData(stateCensusCSVFilePath), stateCodeAnalyser.ReadStateCensusData(stateCensusCSVFilePath));
        }
    }
}