namespace DiscriminantAndVieta.TypeEquation
{
    /// <summary>
    /// Квадратичное уравнение ax2 + 2kx + c = 0 
    /// С четным вторым коэффициентом
    /// </summary>
    public class TypeBIsOdd : ITypeQeCalcByD
    {
        public double CalcDiscriminant(double[] variables)
        {
            return Math.Pow(variables[1], 2) - (variables[0] * variables[2]);
        }
    }
}
