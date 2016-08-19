using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Classes
{
    public class Matrix
    {
        public int Sum(int[][] matrix)
        {
            throw new NotImplementedException();
        }

        public double ArithmeticMean(int[][] matrix)
        {
            throw new NotImplementedException();
        }

        public int[][] Transposition(int[][] matrix)
        {
            throw new NotImplementedException();
        }

        public int RowWithMinimalSum(int[][] matrix)
        {
            throw new NotImplementedException();
        }

        public int RowWithMaximumSum(int[][] matrix)
        {
            throw new NotImplementedException();
        }

        public int ColumnWithMinimalSum(int[][] matrix)
        {
            throw new NotImplementedException();
        }

        public int ColumnWithMaximumSum(int[][] matrix)
        {
            throw new NotImplementedException();
        }
    }
}



















































/*
 * Розв'язки =)
 * return matrix.Sum((m) => m.Sum());
 * return (double)(this.Sum(matrix)) / matrix.Sum((m) => m.Length);
 * int r = 0;
            int t = 0;
            foreach (var vec in matrix)
            {
                r++;
                foreach (var elem in vec) t++;
            }
            t /= r;

            int[][] result = new int[t][];

            for (var i = 0; i < t; i++)
            {
                result[i] = new int[r];
            }

            for (var i = 0; i < r; i++)
            {
                for (var j = 0; j < t; j++)
                {
                    result[j][i] = matrix[i][j];
                }
            }

            return result;
     */
