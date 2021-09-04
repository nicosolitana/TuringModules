using System;
using System.Collections.Generic;
using System.Linq;
using TuringModules.Common;
using TuringModules.Model;

namespace TuringModules.Controller
{
    class Extractor
    {

        private string[] ExtractData(string value, string delimeter)
        {
            var strLst = value.Split(new[] { delimeter },
                StringSplitOptions.None);
            strLst = strLst.Where(s => !string.IsNullOrWhiteSpace(s)).ToArray();
            strLst = strLst.Select(s => s.Trim()).ToArray();
            return strLst;
        }


        private Code ExtractCode(string module)
        {
            Code code = new Code();
            var tokenLst = ExtractData(module, " ");

            if (tokenLst.Length != 2)
                return null;

            string[] mod = ExtractModule(tokenLst[1]);
            if ((mod == null) && (mod.Length != 2))
                return null;

            code.State = (tokenLst[0]).Replace("]", "");
            code.Module = mod[0];

            if(Validator.NoParameterModuleList.IndexOf(mod[0]) != -1)
            {
                code.ParameterOne = null;
                code.ParameterTwo = null;
            }

            if (Validator.OneParameterModuleList.IndexOf(mod[0]) != -1)
            {
                code.ParameterOne = mod[1];
                code.ParameterTwo = null;
            }

            if (Validator.TwoParameterModuleList.IndexOf(mod[0]) != -1)
            {
                code.ParameterOne = mod[1];
                code.ParameterTwo = mod[2];
            }

            return code;
        }

        private string[] ExtractModule(string module)
        {
            string[] mod = new string[3];
            if (module.Contains("-"))
            {
                mod = ExtractData(module, "-");
            }
            else if (module.Contains("("))
            {
                mod = ExtractData(module.Replace("(", "-"), "-");
                mod[1] = mod[1].Replace(")", "");
            } else
            {
                mod[0] = module;
            }

            if (!Validator.IsValidModule(mod[0]))
                return null;

            return mod;
        }

        public List<string> ExtractInput(string input)
        {
            List<string> inputLst = new List<string>();
            string temp = string.Empty;
            input += "#";
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '#')
                {
                    if (!string.IsNullOrEmpty(temp))
                        inputLst.Add(temp);
                    temp = string.Empty;
                    inputLst.Add("#");
                }
                else
                    temp += input[i];
            }
            return inputLst;
        }

        public List<Code> Extract(string code)
        {
            List<Code> TuringCode = new List<Code>();
            if (string.IsNullOrEmpty(code))
                return null;

            var moduleLst = ExtractData(code, Environment.NewLine);

            foreach (var module in moduleLst)
            {
                Code value = ExtractCode(module);

                if (value == null)
                    return null;

                TuringCode.Add(value);
            }

            return TuringCode;
        }
    }
}
