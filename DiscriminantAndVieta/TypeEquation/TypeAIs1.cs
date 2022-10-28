namespace DiscriminantAndVieta.TypeEquation
{
    /// <summary>
    /// Квадратичное уравнение x^2 + px + q = 0
    /// </summary>
    public class TypeAIs1 : ITypeQeCalcByD
    {
        public double CalcDiscriminant(double[] variables)
        {
            return new TypeStandart().CalcDiscriminant(variables);
        }
    }
}
