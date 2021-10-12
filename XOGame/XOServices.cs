using System;
using System.Collections.Generic;
using System.Text;

namespace XOGame
{
    public class XOServices
    {
        //public bool CheckWin(string[] xo)
        //{
        //    foreach (var item in xo)
        //    {
        //        if (item != "x" && item != "o") return false;
        //    }
        //    return IsLine(0, 1, 2, xo) ||
        //            IsLine(3, 4, 5, xo) ||
        //            IsLine(6, 7, 8, xo) ||
        //            IsLine(0, 3, 6, xo) ||
        //            IsLine(1, 4, 7, xo) ||
        //            IsLine(6, 7, 8, xo) ||
        //            IsLine(2, 5, 8, xo) ||
        //            IsLine(0, 4, 8, xo) ||
        //            IsLine(2, 4, 6, xo);
        //}
        //private  bool IsLine(int index0, int index1, int index2, string[] xo)
        //{
        //    var txt = xo[index0];
        //    return xo[index0] == txt && xo[index1] == txt && xo[index2] == txt;
        //}

        public bool CheckWinArray2D(char[,] xo)
        {
            if (!CheckInputInvalid(xo)) return false;

            var result = IsVerticalLine(0, 0, 1, 2, xo) ||
                IsVerticalLine(1, 0, 1, 2, xo) ||
                IsVerticalLine(2, 0, 1, 2, xo) ||
                IsHorizontalLine(0, 0, 1, 2, xo) ||
                IsHorizontalLine(1, 0, 1, 2, xo) ||
                IsHorizontalLine(2, 0, 1, 2, xo) ||
                IsAnyLine(xo[0, 0], xo[1, 1], xo[2, 2]) ||
                IsAnyLine(xo[0, 2], xo[1, 1], xo[2, 0]);
            return result;


        }
        private  bool IsVerticalLine(int verticalIndex, int index1, int index2, int index3, char[,] xo)
        {
            var txt1 = xo[verticalIndex, index1];
            var txt2 = xo[verticalIndex, index2];
            var txt3 = xo[verticalIndex, index3];
            return txt1 == txt2 && txt2 == txt3;
        }

        private  bool IsHorizontalLine(int horizontalIndex, int index1, int index2, int index3, char[,] xo)
        {
            var txt1 = xo[index1, horizontalIndex];
            var txt2 = xo[index2, horizontalIndex];
            var txt3 = xo[index3, horizontalIndex];
            return txt1 == txt2 && txt2 == txt3;
        }
        private  bool IsAnyLine(char one, char two, char three)
        {
            return one ==  two  && two == three;
        }

        public  bool CheckInputInvalid(char[,] xo)
        {
            if (xo[0, 0] != 'x' && xo[0, 0] != 'o'|| 
                xo[0, 1] != 'x' && xo[0, 1] != 'o'||  
                xo[0, 2] != 'x' && xo[0, 2] != 'o'||  
                xo[1, 0] != 'x' && xo[1, 0] != 'o'||  
                xo[1, 1] != 'x' && xo[1, 1] != 'o'||  
                xo[1, 2] != 'x' && xo[1, 2] != 'o'||  
                xo[2, 0] != 'x' && xo[2, 0] != 'o'||  
                xo[2, 1] != 'x' && xo[2, 1] != 'o'||
                xo[2, 2] != 'x' && xo[2, 2] != 'o')  
                return false;
            else
                return true;
        }
    }
}

