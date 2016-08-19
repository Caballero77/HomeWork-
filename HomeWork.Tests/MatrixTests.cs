namespace HomeWork.Tests
{
    using System;
    using NUnit.Framework;
    using System.Collections.Generic;
    using HomeWork.Classes;

    [TestFixture]
    public class MatrixTests
    {
        #region Matrixes

        private List<int[][]> matrixes = new List<int[][]>
        {
            new int[][]{ new[] { 1, 2, 3 },
                         new[] { 4, 5, 6 },
                         new[] { 7, 8, 9} },

            new int[][]{ new[] { 1, 2, 3 },
                         new[] { 3, 2, 1 },
                         new[] { 3, 1, 2 } }
        };

        #endregion

        #region Sum Tests
        private Matrix matrix = new Matrix();

        [Test]
        public void SumTest_1()
        {
            var matrix = new int[][] { new[] { 1, 2, 3 }, new[] { 3, 2, 1 }, new[] { 3, 1, 2 } };
            var expecterResult = 18;

            var result = this.matrix.Sum(matrix);

            Assert.AreEqual(expecterResult,result);
        }

        [Test]
        public void SumTest_2()
        {
            var matrix = new int[][] { new[] { 0, 12, -12 }, new[] { 2, 2, 2 }, new[] { -2, -2, -2 } };
            var expecterResult = 0;

            var result = this.matrix.Sum(matrix);

            Assert.AreEqual(expecterResult, result);
        }

        [Test]
        public void SumTest_3()
        {
            var matrix = new int[][] { new[] { 4, 5, 1 }, new[] { 3, 2, 1 }, new[] { 3, 1, 2 }, new[] { 1, 2, 3 }, new[] { 0, 0, 0 }, new[] { 1, 2, 3, 4, 5 } };
            var expecterResult = 43;

            var result = this.matrix.Sum(matrix);

            Assert.AreEqual(expecterResult, result);
        }

        [Test]
        public void SumTest_4()
        {
            var matrix = new int[][] { new[] { 0 }, new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, new[] { -1, -2, -3, -4, -5, -6, -7, -8, -9 } };
            var expecterResult = 0;

            var result = this.matrix.Sum(matrix);

            Assert.AreEqual(expecterResult, result);
        }

        [Test]
        public void SumTest_5()
        {
            var matrix = new int[][] { new[] { 1 }, new[] { 1, 2 }, new[] { 1, 2, 3 } };
            var expecterResult = 10;

            var result = this.matrix.Sum(matrix);

            Assert.AreEqual(expecterResult, result);
        }
        #endregion

        #region Arithmetic Mean Tests

        [Test]
        public void ArithmeticMean_1()
        {
            var matrix = new int[][] { new[] { 1, 2, 3 }, new[] { 3, 2, 1 }, new[] { 3, 1, 2 } };
            var expecterResult = 18d/9;

            var result = this.matrix.ArithmeticMean(matrix);

            Assert.True(Math.Abs(result - expecterResult) <= 0.00001);
        }

        [Test]
        public void ArithmeticMean_2()
        {
            var matrix = new int[][] { new[] { 1 }, new[] { 3, 4, 5 } };
            var expecterResult = 13d/4;

            var result = this.matrix.ArithmeticMean(matrix);

            Assert.True(Math.Abs(result - expecterResult) <= 0.00001);
        }

        [Test]
        public void ArithmeticMean_3()
        {
            var matrix = new int[][] { new[] { 0, 0, 0, 0, 0 }, new[] { 2, 2, 2, 2, 2 } };
            var expecterResult = 10d/10;

            var result = this.matrix.ArithmeticMean(matrix);

            Assert.True(Math.Abs(result - expecterResult) <= 0.00001);
        }

        [Test]
        public void ArithmeticMean_4()
        {
            var matrix = new int[][] { new[] { 2 }, new[] { 3 },new[] { 5, 3 }, new[] { 2, 6, 4, 2 }, new[] { 2 } };
            var expecterResult = 29d/9;

            var result = this.matrix.ArithmeticMean(matrix);

            Assert.True(Math.Abs(result - expecterResult) <= 0.00001);
        }

        #endregion

        #region Transposition Tests

        [Test]
        public void Transposition_1()
        {
            var matrix = new int[][] { new[] { 1, 2, 3 },
                                       new[] { 3, 2, 1 },
                                       new[] { 3, 1, 2 } };

            var matrixResult = new int[][] { new[] { 1, 3, 3 },
                                             new[] { 2, 2, 1 },
                                             new[] { 3, 1, 2 } };

            var result = this.matrix.Transposition(matrix);

            bool res = true; 

            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    res &= result[i][j] == matrixResult[i][j];
                }
            }
            Assert.True(res);

        }

        [Test]
        public void Transposition_2()
        {
            var matrix = new int[][] { new[] { 1, 2, 3 },
                                       new[] { 3, 2, 1 },
                                       new[] { 3, 1, 2 },
                                       new[] { 2, 1, 3 }};

            var matrixResult = new int[][] { new[] { 1, 3, 3, 2 },
                                             new[] { 2, 2, 1, 1 },
                                             new[] { 3, 1, 2, 3 } };

            var result = this.matrix.Transposition(matrix);

            bool res = true;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    res &= result[i][j] == matrixResult[i][j];
                }
            }
            Assert.True(res);

        }

        #endregion
    }
}
