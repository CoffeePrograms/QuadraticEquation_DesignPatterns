namespace DiscriminantAndVieta.CalculateEquation
{
    /// <summary>
    /// Проверка правильности с помощью теоремы Виета вычисленных корней квадратичного уравнения
    /// </summary>
    public class CheckRootsByVieta : ACalcQe
    {
        public CheckRootsByVieta(double[] variables, double[] roots) : base(variables)
        {
            Roots = roots;
        }

        private bool Sum()
        {
            return Roots[0] + Roots[1] == -1 * Variables[1];
        }

        private bool Mult()
        {
            return Roots[0] * Roots[1] == Variables[2];
        }

        public override void Calc()
        {
            if (Roots == null || Roots.Length != 2 || !(Sum() && Mult()))
            {
                Roots = null;
            }
        }
    }
}
