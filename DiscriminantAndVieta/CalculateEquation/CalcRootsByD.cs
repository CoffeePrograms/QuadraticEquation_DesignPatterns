using DiscriminantAndVieta.CalculateRoots;
using DiscriminantAndVieta.TypeEquation;

namespace DiscriminantAndVieta.CalculateEquation
{
    /// <summary>
    /// Расчет корней квадратичного уравнения в зависимости от его типа с помощью дискриминта
    /// </summary>
    public class CalcRootsByD : ACalcQe
    {
        private protected ITypeQeCalcByD type;

        public CalcRootsByD(ITypeQeCalcByD type, double[] variables) : base(variables)
        {
            this.type = type;
        }

        public override void Calc()
        {
            double d = type.CalcDiscriminant(Variables);

            if (d < 0)
            {
                Roots = null;
                return;
            }

            ACalculateRoots discriminant;
            if (d == 0)
                discriminant = new CalculateOneRoot(Variables);
            else
                discriminant = new CalculateTwoRoots(Variables, d);
            Roots = discriminant.CalcRoots();

            if (type is TypeBqe)
            {
                List<double> doubles = new();
                foreach (var item in Roots)
                {
                    if (item == 0)
                        doubles.Add(0);
                    else if (item > 0)
                    {
                        double res = Math.Sqrt(item);
                        doubles.Add(res);
                        doubles.Add(-res);
                    }
                }
                Roots = doubles.ToArray();
            }
        }
    }
}
