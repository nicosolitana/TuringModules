using System;

namespace TuringModules.Common
{
    static class TestCase
    {
        static string P_MANUAL_SWAP = "1] shR-2" + Environment.NewLine +
                                    "2] copy-2" + Environment.NewLine +
                                    "3] shL-2" + Environment.NewLine +
                                    "4] move-1-2" + Environment.NewLine +
                                    "5] halt";

        static string I_MANUAL_SWAP = "#5#3#";

        static string P_GCD = "1] shR-2" + Environment.NewLine +
                                "2] copy-2" + Environment.NewLine +
                                "3] copy-2" + Environment.NewLine +
                                "4] shL-2" + Environment.NewLine +
                                "5] ifEQ(26)" + Environment.NewLine +
                                "6] copy-2" + Environment.NewLine +
                                "7] copy-2" + Environment.NewLine +
                                "8] shL-2" + Environment.NewLine +
                                "9] ifLT(19)" + Environment.NewLine +
                                "10] copy-2" + Environment.NewLine +
                                "11] copy-2" + Environment.NewLine +
                                "12] shL-2" + Environment.NewLine +
                                "13] monus" + Environment.NewLine +
                                "14] shR-1" + Environment.NewLine +
                                "15] copy-2" + Environment.NewLine +
                                "16] shL-2" + Environment.NewLine +
                                "17] move-2-1" + Environment.NewLine +
                                "18] goto(1)" + Environment.NewLine +
                                "19] copy-2" + Environment.NewLine +
                                "20] copy-2" + Environment.NewLine +
                                "21] shL-2" + Environment.NewLine +
                                "22] monus" + Environment.NewLine +
                                "23] move-1-1" + Environment.NewLine +
                                "24] shR-1" + Environment.NewLine +
                                "25] goto(2)" + Environment.NewLine +
                                "26] move-1-1" + Environment.NewLine +
                                "27] halt";

        static string I_GCD = "#30#36#";

        static string P_SQUARE = "1] shR-1" + Environment.NewLine +
                                "2] const-1" + Environment.NewLine +
                                "3] shR-1" + Environment.NewLine +
                                "4] const-1" + Environment.NewLine +
                                "5] shL-1" + Environment.NewLine +
                                "6] add" + Environment.NewLine +
                                "7] shR-1" + Environment.NewLine +
                                "8] copy-2" + Environment.NewLine +
                                "9] copy-2" + Environment.NewLine +
                                "10] shL-2" + Environment.NewLine +
                                "11] ifEQ(13)" + Environment.NewLine +
                                "12] goto(4)" + Environment.NewLine +
                                "13] shL-2" + Environment.NewLine +
                                "14] mult" + Environment.NewLine +
                                "15] halt";

        static string I_SQUARE = "#4#";

        static string P_COUNT_TO_N = "1] shR-1" + Environment.NewLine +
                                    "2] const-1" + Environment.NewLine +
                                    "3] shL-1" + Environment.NewLine +
                                    "4] swap" + Environment.NewLine +
                                    "5] shR-2" + Environment.NewLine +
                                    "6] copy-2" + Environment.NewLine +
                                    "7] copy-2" + Environment.NewLine +
                                    "8] shL-2" + Environment.NewLine +
                                    "9] ifEQ(18)" + Environment.NewLine +
                                    "10] const-1" + Environment.NewLine +
                                    "11] shR-1" + Environment.NewLine +
                                    "12] copy-3" + Environment.NewLine +
                                    "13] shL-2" + Environment.NewLine +
                                    "14] add" + Environment.NewLine +
                                    "15] shL-1" + Environment.NewLine +
                                    "16] swap" + Environment.NewLine +
                                    "17] goto(5)" + Environment.NewLine +
                                    "18] shL-1" + Environment.NewLine +
                                    "19] move-1-1" + Environment.NewLine +
                                    "20] shR-1" + Environment.NewLine +
                                    "21] halt";

        static string I_COUNT_TO_N = "#3#";

        public static string[] GetDefaultTestCase(string selection)
        {
            string[] testcase = new string[2];
            selection = selection.ToUpper();
            if (selection == "MANUAL SWAP")
            {
                testcase[0] = I_MANUAL_SWAP;
                testcase[1] = P_MANUAL_SWAP;
            }

            if (selection == "GCD")
            {
                testcase[0] = I_GCD;
                testcase[1] = P_GCD;
            }

            if (selection == "SQUARE")
            {
                testcase[0] = I_SQUARE;
                testcase[1] = P_SQUARE;
            }

            if (selection == "COUNT TO N")
            {
                testcase[0] = I_COUNT_TO_N;
                testcase[1] = P_COUNT_TO_N;
            }
            return testcase;
        }
    }
}
