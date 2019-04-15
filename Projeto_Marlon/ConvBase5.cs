using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Marlon
{
    class ConvBase5
    {
        public static string ConvForAll(string num)
        {
            string numFinal = "";
            double nume = 0;
            int cont = 0; 
            for (int i = num.Length; i >= 1; i--)
            {
                nume += int.Parse(num[i - 1].ToString()) * Math.Pow(5, cont);
                cont++;
            }
            numFinal = nume.ToString();
            return numFinal;
        }

        public static string ConvTo5(string num)
        {
            int convNum = int.Parse(num), numAux = 0;
            string strAux = "";
            for (int i = 0; i <= convNum; i++)
            {
                if (i == 0)
                {
                    numAux = i;
                }
                else if (numAux > 0 && strAux.Length >= 4 && strAux[strAux.Length - 1] == '4' && strAux[strAux.Length - 2] == '4' && strAux[strAux.Length - 3] == '4' && strAux[strAux.Length - 4] == '4')
                {
                    numAux += 5556;
                }
                else if (numAux > 0 && strAux.Length >= 3 && strAux[strAux.Length - 1] == '4' && strAux[strAux.Length - 2] == '4' && strAux[strAux.Length - 3] == '4')
                {
                    numAux += 556;
                }
                else if (numAux > 0 && strAux.Length >= 2 && strAux[strAux.Length - 1] == '4' && strAux[strAux.Length - 2] == '4')
                {
                    numAux += 56;
                }
                else if (numAux > 0 && strAux[strAux.Length - 1] == '4')
                {
                    numAux += 6;
                }
                else
                {
                    numAux += 1;
                }
                strAux = numAux.ToString();
            }
            return strAux;
        }
    }
}



//double aux = 0, result = 0;
//int r = 0;
//            if (int.Parse(num) > 4)
//            {
//                aux = double.Parse(num);
//                while (true)
//                {
//                    aux /= 5;
//                    result += aux;
                    
//                    if(aux <= 1)
//                    {
//                        result += aux;
//                        if(result > Math.Truncate(result))
//                        {
//                            result = Math.Truncate(result) + 1;
//                        }
//                        break;
//                    }
//                }
//                num = result.ToString();
//            }
//            return num;