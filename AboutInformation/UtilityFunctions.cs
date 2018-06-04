using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;


namespace AboutInformation
{

    public class ReportAction

    {
        public static void RunPositiveResult(string TextOne)
        {
            string ActualText = "Actual text is: " + TextOne;
            Ranorex.Report.Success("Sucessfully Performed: ", ActualText);
        }


        public static void RunNegativeResult(string TextOne, string TextTwo)
        {
            string ActualText = "Actual text is: " + TextOne;
            Ranorex.Report.Error("STOP THE VERSION: ", ActualText);
            Ranorex.Report.Error("Expected text is: " + TextTwo);
        }
    }

    class UtilityRun
    {
        public static void ComparingText(string Actual, string Hardcoded)
        {
            string strTextOne = Actual;
            string[] strReadTextOneArr = Regex.Split(strTextOne, "\n");
            //int 

            string strHardcodedTextOne = Hardcoded;
            string[] strReadHarcodedTextOneArr = Regex.Split(strHardcodedTextOne, "\n");

            int iArrHardcodedSize = strReadHarcodedTextOneArr.Length;

            for (int i = 0; i < iArrHardcodedSize; i++)
            {
                if ((1 == i) || (2 == i) || (5 == i))   
                    continue;

                if (strReadTextOneArr[i].CompareTo(strReadHarcodedTextOneArr[i]) == 0)
                {
                   
                    ReportAction.RunPositiveResult(strReadTextOneArr[i]);
                }
                else
                {
                    ReportAction.RunNegativeResult(strReadTextOneArr[i], strReadHarcodedTextOneArr[i]);
                }
            }

            
        }

            
    }
}
