namespace DiscriminantAndVieta.TypeEquation
{
    /// <summary>
    /// Неполное квадратичное уравнение ax^2 + bx + c = 0	
    /// </summary>
    public class TypeStandart : ITypeQeCalcByD
    {
        public double CalcDiscriminant(double[] variables)
        {
            return Math.Pow(variables[1], 2) - (4 * variables[0] * variables[2]);
        }
    }
}
