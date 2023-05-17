//complexNumber.cs
using System;


namespace Practica15oap
{
    class ComplexNumbers
    {
        int onefirstNum;
        string onesecondNum;
        int twofirstNum;
        string twosecondNum;
        public ComplexNumbers(int onefirstNum, string onesecondNum, int twofirstNum, string twosecondNum)
        {
            this.onefirstNum = onefirstNum;
            this.onesecondNum = onesecondNum;
            this.twofirstNum = twofirstNum;
            this.twosecondNum = twosecondNum;
        }
       
        public bool sing(string text)
        {
            if (text[0] == '+') return true;
            else if (text[0] == '-') return false;
            else return true;
        }
        public int receiptInt(string user)
        {
            string number = "";
            for(int i = 0; i < user.Length; i++)
            {
                if (Char.IsDigit(user[i]) == true) number += user[i];
            }
            if (number.Length > 0) return Convert.ToInt32(number);
            else return 1;
        }

        public int returnNum(string complex)
        {
            int number = receiptInt(complex);
            if (sing(complex) == false) number = number * -1;
            return number;
        }
        public string addition() //сложение
        {
            int firstSum = onefirstNum + twofirstNum;
            int secondsum = returnNum(onesecondNum) + returnNum(twosecondNum);
            if(sing(Convert.ToString(secondsum)) == true)
            {
                return firstSum + " + " + secondsum + "i";
            }
            else return firstSum +" " + secondsum + "i";
        }

        public string subtraction() //вычитание
        {
            int firstSum = onefirstNum - twofirstNum;
            int secondsum = returnNum(onesecondNum) - returnNum(twosecondNum);
            if (sing(Convert.ToString(secondsum)) == true)
            {
                return firstSum + " - " + secondsum + "i";
            }
            else return firstSum +" " + secondsum + "i";
        }

        public string multiplication() //умножение
        {
            int firstSum = (onefirstNum * twofirstNum) - (returnNum(onesecondNum) * returnNum(twosecondNum));
            int secondsum = (onefirstNum * returnNum(twosecondNum)) + (twofirstNum * returnNum(onesecondNum));
            if (sing(Convert.ToString(secondsum)) == true)
            {
                return firstSum + " + " + secondsum + "i";
            }
            else return firstSum + " " + secondsum + "i";
        }
    }
}
