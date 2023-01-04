using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStatesCensusAnalyser
{
    public class StateCensusAndCodeException:Exception
    {
        public enum ExceptionType
        {

        }
        public StateCensusAndCodeException(ExceptionType exceptionType, string message): base(message)
        {

        }
    }
}
