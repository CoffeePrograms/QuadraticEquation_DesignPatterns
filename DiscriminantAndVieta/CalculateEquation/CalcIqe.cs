using DiscriminantAndVieta.TypeEquation;

namespace DiscriminantAndVieta.CalculateEquation
{
    /// <summary>
    /// Расчет неполных квадратичных уравнений (Incomplete Quadratic Equation)
    /// </summary>
    public class CalcIqe : ACalcQe
    {
        private ITypeIqe type;
        private double[] variables;

        public CalcIqe(ITypeIqe type, double[] variables) : base(variables)
        {
            this.type = type;
            this.variables = variables;
        }

        public override void Calc()
        {
            Roots = type.Calc(variables);
        }
    }
}
