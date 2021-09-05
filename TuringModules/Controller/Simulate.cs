using System;
using System.Linq;
using System.Windows.Forms;
using TuringModules.Model;

namespace TuringModules.Controller
{
    class Simulate
    {

        private string errMsg = string.Empty;

        // Need to update for the additional # at the end
        private void MathOps(SimulationData simData, int lineNumber, string operation, string module)
        {
            module = string.Format("{0}] {1}", lineNumber, operation);
            if (((simData.Pointer * 2) + 4) == simData.IO.Count() - 1)
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

        private void Swap(SimulationData simData, int lineNumber, string module)
        {
            module = string.Format("{0}] {1}", lineNumber, "swap");
            if (((simData.Pointer * 2) + 4) <= simData.IO.Count() - 1)
            {
                int temp = Int32.Parse(simData.IO[(simData.Pointer * 2) + 1]);
                simData.IO[(simData.Pointer * 2) + 1] = simData.IO[(simData.Pointer * 2) + 3];
                simData.IO[(simData.Pointer * 2) + 3] = temp.ToString();
            }
            else
                errMsg = string.Format("[ERROR] Shift Left pointer goes beyond lower bound of the array on line {0}.", lineNumber.ToString());
        }

        private void ShiftLeft(SimulationData simData, int lineNumber, string module)
        {
            int pos = Int32.Parse(simData.TuringCode[lineNumber].ParameterOne);
            module = string.Format("{0}] {1}", lineNumber, "shL-" + pos.ToString());
            int currentPos = simData.Pointer;
            if (pos <= currentPos)
                simData.Pointer = currentPos - pos;
            else
                errMsg = string.Format("[ERROR] Shift Left pointer goes beyond lower bound of the array on line {0}.", lineNumber.ToString());
        }

        // should divide into 2 in case you add more
        private void ShiftRight(SimulationData simData, int lineNumber, string module)
        {
            int pos = Int32.Parse(simData.TuringCode[lineNumber].ParameterOne);
            module = string.Format("{0}] {1}", lineNumber, "shR-" + pos.ToString());
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

        private void Copy(SimulationData simData, int lineNumber, string module)
        {
            int pos = Int32.Parse(simData.TuringCode[lineNumber].ParameterOne) * 2;
            module = string.Format("{0}] {1}", lineNumber, "copy-" + pos.ToString());
            int currentPos = simData.Pointer * 2;
            if (pos <= currentPos)
            {
                int index = (currentPos - pos) + 1;
                simData.IO.Add(simData.IO[index]);
                simData.IO.Add("#");
                simData.Pointer = (simData.IO.Count() - 1) / 2;
            }
            else
                errMsg = string.Format("[ERROR] Shift Left pointer goes beyond lower bound of the array on line {0}.", lineNumber.ToString());
        }

        private int EvalConditions(SimulationData simData, int lineNumber, string operation, string module)
        {
            bool result = false;
            int nextLine = Int32.Parse(simData.TuringCode[lineNumber].ParameterOne);
            module = string.Format("{0}] {1}({2})", lineNumber, operation, nextLine.ToString());
            //if ((simData.Pointer * 2) == simData.IO.Count() - 6)
            if (((simData.Pointer * 2) + 4) == simData.IO.Count() - 1)
            {
                int firstValue  = Int32.Parse(simData.IO[(simData.IO.Count() - 4)]);
                int secondValue = Int32.Parse(simData.IO[(simData.IO.Count() - 2)]);
                switch (operation)
                {
                    case "ifGT":
                        result = firstValue > secondValue ? true : false;
                        break;
                    case "ifEQ":
                        result = firstValue == secondValue ? true : false;
                        break;
                    case "ifGE":
                        result = firstValue >= secondValue ? true : false;
                        break;
                    case "ifLT":
                        result = firstValue < secondValue ? true : false;
                        break;
                    case "ifLE":
                        result = firstValue <= secondValue ? true : false;
                        break;
                }

                simData.IO.RemoveRange(simData.IO.Count - 5, 4);

                if (result)
                    return nextLine;
                else
                    return -1;
            }
            else
                errMsg = string.Format("[ERROR] Shift Left pointer goes beyond lower bound of the array on line {0}.", lineNumber.ToString());
            
            return -1;
        }

        private int GoTo(SimulationData simData, int lineNumber, string module)
        {
            int nextLine = Int32.Parse(simData.TuringCode[lineNumber].ParameterOne);
            module = string.Format("{0}] {1}", lineNumber, "goto-" + nextLine.ToString());
            return nextLine;
        }

        private void Constant(SimulationData simData, int lineNumber, string module)
        {
            string value = simData.TuringCode[lineNumber].ParameterOne;
            module = string.Format("{0}] {1}", lineNumber, "const-" + value.ToString());
            if ((simData.Pointer * 2) == (simData.IO.Count()-1))
            {
                simData.IO.Add(value);
                simData.IO.Add("#");
            }
            else
                errMsg = string.Format("[ERROR] Current Pointer is not at the end of list on operation constant at line {0}.", lineNumber.ToString());
        }

        // MIGHT HAVE BUGS DUE TO POINTER LOCATION
        private void Move(SimulationData simData, int lineNumber, string module)
        {
            int ptrPosition = Int32.Parse(simData.TuringCode[lineNumber].ParameterOne) * 2;
            int itemCount = Int32.Parse(simData.TuringCode[lineNumber].ParameterTwo) * 2;
            module = string.Format("{0}] {1}-{2}-{3}", lineNumber, "move", ptrPosition, itemCount);

            if ((simData.Pointer * 2) >= ptrPosition)
            {
                simData.Pointer = (simData.Pointer * 2) - ptrPosition;
                simData.IO.RemoveRange(simData.Pointer, itemCount);
            }
            else
                errMsg = string.Format("[ERROR] Current Pointer is not at the end of list on operation constant at line {0}.", lineNumber.ToString());
        }

        private void UpdateSimulationResult(string simulation)
        {
            TuringModGUI.SimulationResult.Invoke(new MethodInvoker(delegate
            {
                TuringModGUI.SimulationResult.Text = TuringModGUI.SimulationResult.Text + (simulation);
            }));
        }

        public void Start(SimulationData simData)
        {
            int lineNumber = 0;
            bool IsExecute = true;
            string module = string.Empty;
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
                        MathOps(simData, lineNumber, op, module);
                        lineNumber++;
                        break;
                    case "swap":
                        Swap(simData, lineNumber, module);
                        lineNumber++;
                        break;
                    case "const":
                        Constant(simData, lineNumber, module);
                        lineNumber++;
                        break;
                    case "shR":
                        ShiftRight(simData, lineNumber, module);
                        lineNumber++;
                        break;
                    case "shL":
                        ShiftLeft(simData, lineNumber, module);
                        lineNumber++; 
                        break;
                    case "copy": 
                        Copy(simData, lineNumber, module);
                        lineNumber++;
                        break;
                    case "ifGT": 
                    case "ifEQ": 
                    case "ifGE": 
                    case "ifLT": 
                    case "ifLE":   // REMOVE LAST TWO VALUES WHEN COMPARE
                        int result = EvalConditions(simData, lineNumber, op, module);
                        lineNumber = (result != -1) ? result-1 : lineNumber+1;
                        break;
                    case "goto": 
                        lineNumber = GoTo(simData, lineNumber, module) - 1;
                        break;
                    case "move":
                        Move(simData, lineNumber, module);
                        lineNumber++;
                        break;   // NOT YET DONE MOVE OPERATION
                    case "halt":
                        IsExecute = false;
                        break;
                }

                // UPDATE OUTOUT HERE
                string output = module + "     " + String.Join("     ", simData.IO) + Environment.NewLine;
                UpdateSimulationResult(output);
            }
        }
    }
}
