namespace DiscriminantAndVieta.TypeEquation
{
    /// <summary>
    /// Неполное квадратичное уравнение ax^2 + c = 0
    /// </summary>
    public class TypeIncompleteQeBIsZero : ITypeIqe
    {
        public double[] Calc(double[] variables)
        {
            double temp = Math.Sqrt(-variables[2] / variables[0]);
            if (temp == 0)
                return new double[] { 0 };
            else if (temp > 1)
                return new double[] { temp, -1 * temp };
            else
                return null;
        }
    }
}
