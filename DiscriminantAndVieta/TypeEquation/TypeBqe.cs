namespace DiscriminantAndVieta.TypeEquation
{
    /// <summary>
    /// Биквадратное уравнение ax^4 + bx^2 + c = 0 (Biquadrate Equation)
    /// </summary>
    public class TypeBqe : ITypeQeCalcByD
    {
        public double CalcDiscriminant(double[] variables)
        {
            return new TypeStandart().CalcDiscriminant(variables);
        }
    }
}
