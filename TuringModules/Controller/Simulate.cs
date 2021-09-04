using System;
using System.Linq;
using TuringModules.Model;

namespace TuringModules.Controller
{
    class Simulate
    {

        private string errMsg = string.Empty;

        // Need to update for the additional # at the end
        private void MathOps(SimulationData simData, int lineNumber, string operation)
        {
            if (((simData.Pointer * 2) + 3) == simData.IO.Count() - 1)
            {
                int firstValue = Int32.Parse(simData.IO[(simData.Pointer * 2) + 1]);
                int seconvValue = Int32.Parse(simData.IO[(simData.Pointer * 2) + 3]);
                int result = 0;
                switch (operation)
                {
                    case "add":
                        result = firstValue + seconvValue;
                        break;
                    case "sub":
                        result = firstValue - seconvValue;
                        break;
                    case "mult":
                        result = firstValue * seconvValue;
                        break;
                    case "div":
                        result = firstValue / seconvValue;
                        break;      
                    case "monus":
                        result = (firstValue > seconvValue) ? firstValue - seconvValue : 0;
                        break;
                }
                simData.IO[(simData.Pointer * 2) + 1] = result.ToString();
                simData.IO.RemoveRange(simData.IO.Count - 2, 2);
            }
            else
                errMsg = string.Format("[ERROR] Invalid position of pointer on operation {0} in line {1}.", operation, lineNumber.ToString());
        }

        private void Swap(SimulationData simData, int lineNumber)
        {
            if (((simData.Pointer * 2) + 3) <= simData.IO.Count() - 1)
            {
                int temp = Int32.Parse(simData.IO[(simData.Pointer * 2) + 1]);
                simData.IO[(simData.Pointer * 2) + 1] = simData.IO[(simData.Pointer * 2) + 3];
                simData.IO[(simData.Pointer * 2) + 3] = temp.ToString();
            }
            else
                errMsg = string.Format("[ERROR] Shift Left pointer goes beyond lower bound of the array on line {0}.", lineNumber.ToString());
        }

        private void ShiftLeft(SimulationData simData, int lineNumber)
        {
            int pos = Int32.Parse(simData.TuringCode[lineNumber].ParameterOne);
            int currentPos = simData.Pointer;
            if (pos <= currentPos)
                simData.Pointer = currentPos - pos;
            else
                errMsg = string.Format("[ERROR] Shift Left pointer goes beyond lower bound of the array on line {0}.", lineNumber.ToString());
        }

        private void ShiftRight(SimulationData simData, int lineNumber)
        {
            int pos = Int32.Parse(simData.TuringCode[lineNumber].ParameterOne);
            int currentPos = simData.Pointer;
            int totalPos = (pos + currentPos) * 2;

            if(totalPos > simData.IO.Count())
            {
                int upperBound = ((currentPos + pos) * 2) - simData.IO.Count();
                for (int i = 0; i <= upperBound; i++)
                {
                    simData.IO.Add("#");
                    simData.IO.Add(null);
                }
            }
            simData.Pointer = pos + currentPos;
        }

        private void Copy(SimulationData simData, int lineNumber)
        {
            int pos = Int32.Parse(simData.TuringCode[lineNumber].ParameterOne);
            int currentPos = simData.Pointer;
            if (pos < currentPos)
            {
                int index = (currentPos - (2 * pos)) + 1;
                simData.IO.Add(simData.IO[index]);
                simData.IO.Add("#");
                simData.Pointer = simData.IO.Count() - 1;
            }
            else
                errMsg = string.Format("[ERROR] Shift Left pointer goes beyond lower bound of the array on line {0}.", lineNumber.ToString());
        }

        private int EvalConditions(SimulationData simData, int lineNumber, string operation)
        {
            bool result = false;

            int firstValue = Int32.Parse(simData.IO[(simData.IO.Count()-2)]);
            int seconvValue = Int32.Parse(simData.IO[(simData.IO.Count() - 4)]);
            if (simData.Pointer == simData.IO.Count() - 1)
            {
                switch (operation)
                {
                    case "ifGT":
                        result = firstValue > seconvValue ? true : false;
                        break;
                    case "ifEQ":
                        result = firstValue == seconvValue ? true : false;
                        break;
                    case "ifGE":
                        result = firstValue >= seconvValue ? true : false;
                        break;
                    case "ifLT":
                        result = firstValue < seconvValue ? true : false;
                        break;
                    case "ifLE":
                        result = firstValue <= seconvValue ? true : false;
                        break;
                }

                if (result)
                    return Int32.Parse(simData.TuringCode[lineNumber].ParameterOne);
                else
                    return -1;
            }
            else
                errMsg = string.Format("[ERROR] Shift Left pointer goes beyond lower bound of the array on line {0}.", lineNumber.ToString());
            
            return -1;
        }

        private int GoTo(SimulationData simData, int lineNumber)
        {
            return Int32.Parse(simData.TuringCode[lineNumber].ParameterOne);
        }
        private void Constant(SimulationData simData, int lineNumber)
        {
            string value = simData.TuringCode[lineNumber].ParameterOne;
            if(simData.Pointer == (simData.IO.Count()-1))
            {
                simData.IO.Add(value);
                simData.IO.Add("#");
            }
            else
                errMsg = string.Format("[ERROR] Current Pointer is not at the end of list on operation constant at line {0}.", lineNumber.ToString());
        }

        public void Start(SimulationData simData)
        {
            int lineNumber = 0;
            bool IsExecute = true;
            while (IsExecute)
            {
                string op = simData.TuringCode[lineNumber].Module;
                switch (op)
                {
                    case "add":
                    case "sub":
                    case "mult":
                    case "div": 
                    case "monus":
                        MathOps(simData, lineNumber, op);
                        lineNumber++;
                        break;
                    case "swap":
                        Swap(simData, lineNumber);
                        lineNumber++;
                        break;
                    case "const":
                        Constant(simData, lineNumber);
                        lineNumber++;
                        break;
                    case "shR":
                        ShiftRight(simData, lineNumber);
                        lineNumber++;
                        break;
                    case "shL":
                        ShiftLeft(simData, lineNumber);
                        lineNumber++; 
                        break;
                    case "copy": 
                        Copy(simData, lineNumber);
                        lineNumber++;
                        break;
                    case "ifGT": 
                    case "ifEQ": 
                    case "ifGE": 
                    case "ifLT": 
                    case "ifLE":
                        int result = EvalConditions(simData, lineNumber, op);
                        lineNumber = (result != -1) ? result : lineNumber++;
                        break;
                    case "goto": 
                        lineNumber = GoTo(simData, lineNumber);
                        break;
                    case "move": break;   // NOT YET DONE MOVE OPERATION
                    case "halt":
                        IsExecute = false;
                        break;
                }
            }
        }
    }
}
