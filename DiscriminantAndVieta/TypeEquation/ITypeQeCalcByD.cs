namespace DiscriminantAndVieta.TypeEquation
{
    /// <summary>
    /// Интерфейс для расчета дискриминанта в зависимости от типа квадратичного уравнения (Quadratic Equation)
    /// </summary>
    public interface ITypeQeCalcByD
    {
        double CalcDiscriminant(double[] variables);
    }
}
