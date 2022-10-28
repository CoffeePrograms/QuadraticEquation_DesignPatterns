namespace DiscriminantAndVieta.TypeEquation
{
    /// <summary>
    /// Неполное квадратичное уравнение ax^2 + bx = 0	
    /// </summary>
    public class TypeIncompleteQeCIsZero : ITypeIqe
    {
        public double[] Calc(double[] variables)
        {
            return new double[] { 0, -variables[1] / variables[0] };
        }
    }
}
