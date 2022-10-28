using DiscriminantAndVieta.CalculateEquation;
using DiscriminantAndVieta.TypeEquation;
using NUnit.Framework.Internal;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodAIs1()
        {
            ACalcQe equation = new CalcQeByD(new TypeAIs1(), new double[] { 1, -6, 9 }); // 3
            equation.Calc();
            Assert.AreEqual(1, equation.Roots.Length);
            Assert.AreEqual(3, equation.Roots[0]);
            Assert.AreEqual(null, equation.IsSuccessfullyChecked);

            equation = new CalcQeByD(new TypeAIs1(), new double[] { 1, -4, -5 }); // 5, -1
            equation.Calc();

            Assert.AreEqual(2, equation.Roots.Length);
            double[] result = new double[] { 5, -1 };
            for (int i = 0; i < result.Length; i++)
            {
                Assert.AreEqual(result[i], Math.Round(equation.Roots[i], 2));
            }
            Assert.AreEqual(true, equation.IsSuccessfullyChecked);
        }

        [TestMethod]
        public void TestMethodStandart()
        {
            ACalcQe equation = new CalcQeByD(new TypeStandart(), new double[] { 3, -4, 2 }); // no
            equation.Calc();
            Assert.AreEqual(null, equation.Roots);
            Assert.AreEqual(null, equation.IsSuccessfullyChecked);
        }

        [TestMethod]
        public void TestMethodBqe()
        {
            ACalcQe equation = new CalcQeByD(new TypeBqe(), new double[] { 1, -10, 9 }); // 3, -3, 1, -1
            equation.Calc();
            Assert.AreEqual(4, equation.Roots.Length);
            double[] result = new double[] { 3, -3, 1, -1 };
            for (int i = 0; i < result.Length; i++)
            {
                Assert.AreEqual(result[i], Math.Round(equation.Roots[i], 2));
            }
        }

        [TestMethod]
        public void TestMethodIqe()
        {
            ACalcQe equation;
            double[] result;
            
            // Ќеполные квадратные уравнени€
            equation = new CalcIqe(new TypeIncompleteQeCIsZero(), new double[] { 1, -12, 0 }); // 0, 12
            equation.Calc();
            Assert.AreEqual(2, equation.Roots.Length);
            result = new double[] { 0, 12 };
            for (int i = 0; i < result.Length; i++)
            {
                Assert.AreEqual(result[i], Math.Round(equation.Roots[i], 2));
            }

            equation = new CalcIqe(new TypeIncompleteQeCIsZero(), new double[] { 7, -1, 0 }); // 0, 0.14
            equation.Calc();
            Assert.AreEqual(2, equation.Roots.Length);
            result = new double[] { 0, 0.14 };
            for (int i = 0; i < result.Length; i++)
            {
                Assert.AreEqual(result[i], Math.Round(equation.Roots[i], 2));
            }

            equation = new CalcIqe(new TypeIncompleteQeBIsZero(), new double[] { 1, 0, -12 }); // 3.46, -3.46
            equation.Calc();
            Assert.AreEqual(2, equation.Roots.Length);
            result = new double[] { 3.46, -3.46 };
            for (int i = 0; i < result.Length; i++)
            {
                Assert.AreEqual(result[i], Math.Round(equation.Roots[i], 2));
            }

            equation = new CalcIqe(new TypeIncompleteQeBIsZero(), new double[] { 1, 0, -16 }); // 4, -4
            equation.Calc();
            Assert.AreEqual(2, equation.Roots.Length);
            result = new double[] { 4, -4 };
            for (int i = 0; i < result.Length; i++)
            {
                Assert.AreEqual(result[i], Math.Round(equation.Roots[i], 2));
            }

            equation = new CalcIqe(new TypeIncompleteQeBIsZero(), new double[] { 2, 0, 18 }); // нет корней
            equation.Calc();
            Assert.AreEqual(equation.Roots, null);

            equation = new CalcIqe(new TypeIncompleteQeBIsZero(), new double[] { 2, 0, -18 }); // 3, -3
            equation.Calc();
            Assert.AreEqual(2, equation.Roots.Length);
            result = new double[] { 3, -3 };
            for (int i = 0; i < result.Length; i++)
            {
                Assert.AreEqual(result[i], Math.Round(equation.Roots[i], 2));
            }
        }
    }
}