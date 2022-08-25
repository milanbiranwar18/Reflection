using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionAssignment
{
    public class MoodAnalyser
    {
        public string message;

        public MoodAnalyser(string message)
        {
            this.message = message;
        }

        public MoodAnalyser()
        {

        }

        public string AnalyseMood()
        {
            try
            {

                if (this.message.Contains("SAD"))
                {
                    return "SAD";
                }
                else

                {
                    return "HAPPY";
                }

            }
            catch
            {
                return "HAPPY";
            }
        }
    }
}
