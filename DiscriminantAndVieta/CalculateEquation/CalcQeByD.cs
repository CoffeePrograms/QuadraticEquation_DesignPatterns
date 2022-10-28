using DiscriminantAndVieta.TypeEquation;

namespace DiscriminantAndVieta.CalculateEquation
{
    /// <summary>
    /// Расчет квадратичного уравнения с помощью дискриминанта
    /// </summary>
    public class CalcQeByD : ACalcQe
    {
        private ITypeQeCalcByD type;
        private ACalcQe calc;

        public CalcQeByD(ITypeQeCalcByD type, double[] variables) : base(variables)
        {
            this.type = type;
            calc = new CalcRootsByD(type, variables);

            IsSuccessfullyChecked = null;
        }

        public override double[] Roots { get => calc.Roots; }
        public override double[] Variables { get => calc.Variables; }

        public override void Calc()
        {
            calc.Calc();

            if (type is TypeAIs1 && calc.Roots != null && calc.Roots.Length == 2)
            {
                ACalcQe checkWithVieta = new CheckRootsByVieta(calc.Variables, calc.Roots);
                checkWithVieta.Calc();

                IsSuccessfullyChecked = checkWithVieta.Roots != null;
            }
            else
                IsSuccessfullyChecked = null;

        }
    }
}
