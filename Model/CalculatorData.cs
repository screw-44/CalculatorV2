using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Media.Animation;

namespace CalculatorV2.Model
{
    internal class CalculatorData
    {
        public string processLine { get; set; }
        public string historyLine { get; set; }
        public double result;

        public bool DoCalculate()
        {
            double num1 = 0;
            double num2 = 0;

            string str_num = "";
            int calculate_flag = 0;// 1 for add; 2 for sub; 3 for mul; 4 for div
            for (int i=0; i < processLine.Length; i++)
            {
                // num case 
                if (processLine[i] >= '0' && processLine[i] <= '9')
                {
                    str_num += processLine[i];
                    continue;
                }

                // Parse str to double 
                if (num1 == 0)
                    double.TryParse(str_num, out num1);
                else
                    double.TryParse(str_num, out num2);

                str_num = "";

                // there has been a sign used.
                if (calculate_flag != 0)
                {
                    switch(calculate_flag)
                    {
                        case 1:
                            num1 = num1 + num2;
                            break;
                        case 2:
                            num1 = num1 - num2;
                            break;
                        case 3:
                            num1 = num1 * num2;
                            break;
                        case 4:
                            num1 = num1 / num2;
                            break;
                    }
                    calculate_flag = 0;
                }
                
                // define the new calculate flag for next calculation
                switch (processLine[i])
                {
                    case '+':
                        calculate_flag = 1;
                        break;
                    case '-':
                        calculate_flag = 2;
                        break;
                    case '*':
                        calculate_flag = 3;
                        break;
                    case '/':
                        calculate_flag = 4;
                        break;
                }
            }
            // final calculation after the loop
            if (num1 == 0)
                double.TryParse(str_num, out num1);
            else
                double.TryParse(str_num, out num2);
            if (calculate_flag != 0)
            {
                switch (calculate_flag)
                {
                    case 1:
                        result = num1 + num2;
                        break;
                    case 2:
                        result = num1 - num2;
                        break;
                    case 3:
                        result = num1 * num2;
                        break;
                    case 4:
                        result = num1 / num2;
                        break;
                }
            } 
            else
            {
                result = num1;
            }


            return true;
        }
    }
}
